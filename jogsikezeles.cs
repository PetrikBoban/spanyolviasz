using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TollÚtdíj
{
    


    public partial class jogsikezeles : Form
    {
        private readonly string role;
        private readonly int cegId;
        bool hozzaadas = false;
        private readonly string[] osszesKategoria = { "C", "C1", "C1E", "CE" };


        public jogsikezeles(string role, int cegId)
        {
            InitializeComponent();
            this.role = role;
            this.cegId = cegId;
            lblhibas.Visible = false;
            cbbsoforlista.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbkateg.DropDownStyle = ComboBoxStyle.DropDownList;

            if (role == "operator")
            {
                this.Text = "Sofőr kezelés - Operátor";
            }
            else if (role == "ceg_admin")
            {
                this.Text = "Sofőr kezelés - Adminisztrátor";

            }
            else if (role == "rendszer_admin")
            {
                this.Text = "Sofőr - Rendszer adminisztrátor";
               
            }
        }
        


        private void jogsikezeles_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                try
                {
                    kapcsolat.Open();
                }
                catch
                {
                    lblhibas.Text = "Adatbetöltési hiba.\r\nEllenőrizze az internetkapcsolatot.";
                    lblhibas.Visible = true;
                    lblhibas.ForeColor = Color.Red;
                    
                    return;
                }

                var parancs = kapcsolat.CreateCommand();

                if (role == "rendszer_admin")
                {
                    parancs.CommandText = @"
                SELECT a.nev, c.nev AS ceg_nev
                FROM soforok a
                JOIN cegek c ON a.ceg_id = c.id
                ORDER BY c.nev, a.nev";
                }
                else
                {
                    parancs.CommandText = @"
                SELECT nev
                FROM soforok
                WHERE ceg_id = @cegId
                ORDER BY nev";

                    parancs.Parameters.AddWithValue("@cegId", cegId);
                }

                using (var reader = parancs.ExecuteReader())
                {
                    cbbsoforlista.Items.Clear();

                    while (reader.Read())
                    {
                        if (role == "rendszer_admin")
                        {
                            cbbsoforlista.Items.Add(
                                $"{reader.GetString("nev")} | {reader.GetString("ceg_nev")}"
                            );
                            cbbsoforlista.SelectedIndex = 0;
                        }
                        else
                        {
                            cbbsoforlista.Items.Add(reader.GetString("nev"));
                            cbbsoforlista.SelectedIndex = 0;
                        }
                    }


                }
                
            }
        }
        private void BetoltJogositvanyok(int soforId)
        {
            cbbkateg.Items.Clear();

            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
            SELECT kategoria, erv_tol, erv_ig
            FROM jogositvanyok
            WHERE sofor_id = @sid";

                parancs.Parameters.AddWithValue("@sid", soforId);

                using (var reader = parancs.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbbkateg.Items.Add(reader.GetString("kategoria"));
                    }
                }
            }

            if (cbbkateg.Items.Count > 0)
                cbbkateg.SelectedIndex = 0;
        }
        private int GetSoforId(string soforNev)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = "SELECT id FROM soforok WHERE nev = @nev";
                parancs.Parameters.AddWithValue("@nev", soforNev);

                return Convert.ToInt32(parancs.ExecuteScalar());
            }
        }

        private void btnvissza_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        

        private void cbbsoforlista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbsoforlista.SelectedItem == null)
                return;

            string soforNev = cbbsoforlista.Text.Split('|')[0].Trim();

            int soforId = GetSoforId(soforNev);  // lekéri az ID-t
            BetoltJogositvanyok(soforId);       // feltölti a kategóriát és érvényességeke

        }

        

        private void cbbkateg_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbkateg.SelectedItem == null || hozzaadas)
                return;

            string soforNev = cbbsoforlista.Text.Split('|')[0].Trim();
            int soforId = GetSoforId(soforNev);
            string kategoria = cbbkateg.SelectedItem.ToString();

            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();
                var parancs = kapcsolat.CreateCommand();

                parancs.CommandText = @"
            SELECT erv_tol, erv_ig
            FROM jogositvanyok
            WHERE sofor_id = @sid AND kategoria = @kat";

                parancs.Parameters.AddWithValue("@sid", soforId);
                parancs.Parameters.AddWithValue("@kat", kategoria);

                using (var reader = parancs.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dtpErvTol.Value = reader.GetDateTime("erv_tol");
                        dtpErvIg.Value = reader.GetDateTime("erv_ig");
                    }
                    else
                    {
                        // nincs még ilyen kategória → új adat
                        dtpErvTol.Value = DateTime.Today;
                        dtpErvIg.Value = DateTime.Today;
                        hozzaadas = true;
                    }
                }
            }
        }

        private void btnhozzaadas_Click(object sender, EventArgs e)
        {
            if (!hozzaadas)
            {
          
                hozzaadas = true;
                btnhozzaadas.Text = "Mégse";

                cbbkateg.Items.Clear();
                cbbkateg.Items.AddRange(osszesKategoria);
                cbbkateg.SelectedIndex = -1;

                dtpErvTol.Value = DateTime.Today;
                dtpErvIg.Value = DateTime.Today;

                cbbkateg.Focus();
            }
            else
            {
               
                hozzaadas = false;
                btnhozzaadas.Text = "Új kategória hozzáadása";

                if (cbbsoforlista.SelectedItem == null)
                    return;

                string soforNev = cbbsoforlista.Text.Split('|')[0].Trim();
                int soforId = GetSoforId(soforNev);

                BetoltJogositvanyok(soforId);
            }
        }
        
        private void btnmentes_Click(object sender, EventArgs e)
        {
            if (cbbsoforlista.SelectedItem == null || string.IsNullOrWhiteSpace(cbbkateg.Text))
            {
                MessageBox.Show("Hiányzó adatok!");
                return;
            }

            string soforNev = cbbsoforlista.Text.Split('|')[0].Trim();
            int soforId = GetSoforId(soforNev);

            string kategoria = cbbkateg.Text.Trim();

            if (hozzaadas && VanMarIlyenKategoria(soforId, kategoria))
            {
                lblhibas.Text = "Ez a kategória már létezik ennél a sofőrnél!";
                lblhibas.ForeColor = Color.Red;
                lblhibas.Visible = true;
                return;
            }

            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();
                var parancs = kapcsolat.CreateCommand();

                if (hozzaadas)
                {
                 
                    parancs.CommandText = @"
                INSERT INTO jogositvanyok (sofor_id, kategoria, erv_tol, erv_ig)
                VALUES (@sid, @kat, @tol, @ig)";
                }
                else
                {
                  
                    parancs.CommandText = @"
                UPDATE jogositvanyok
                SET erv_tol = @tol, erv_ig = @ig
                WHERE sofor_id = @sid AND kategoria = @kat";
                }

                parancs.Parameters.AddWithValue("@sid", soforId);
                parancs.Parameters.AddWithValue("@kat", cbbkateg.Text.Split('|')[0]);
                parancs.Parameters.AddWithValue("@tol", dtpErvTol.Value);
                parancs.Parameters.AddWithValue("@ig", dtpErvIg.Value);


               
                    parancs.ExecuteNonQuery();
                lblhibas.Text = "Sikeres mentés!";
                lblhibas.ForeColor = Color.Green;
    
                lblhibas.Visible = true;

            }

            hozzaadas = false;
            BetoltJogositvanyok(soforId);
            btnhozzaadas.Text = "Új kategória hozzáadása";
        }
        private bool VanMarIlyenKategoria(int soforId, string kategoria)
        {
            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
            SELECT COUNT(*)
            FROM jogositvanyok
            WHERE sofor_id = @sid AND kategoria = @kat";

                parancs.Parameters.AddWithValue("@sid", soforId);
                parancs.Parameters.AddWithValue("@kat", kategoria);

                return Convert.ToInt32(parancs.ExecuteScalar()) > 0;
            }
        }
        
        private void btntorles_Click(object sender, EventArgs e)
        {
            if (cbbkateg.SelectedItem == null)
                return;


            string soforNev = cbbsoforlista.Text.Split('|')[0].Trim();
            int soforId = GetSoforId(soforNev);
            string kategoria = cbbkateg.Text.Split('|')[0];

            MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "mysql",
                Database = "tollutdijadatbazis"
            };

            using (MySqlConnection kapcsolat = new MySqlConnection(build.ConnectionString))
            {
                kapcsolat.Open();
                var parancs = kapcsolat.CreateCommand();

                parancs.CommandText = @"
            DELETE FROM jogositvanyok
            WHERE sofor_id = @sid AND kategoria = @kat";

                parancs.Parameters.AddWithValue("@sid", soforId);
                parancs.Parameters.AddWithValue("@kat", kategoria);

                parancs.ExecuteNonQuery();
                lblhibas.Text = "Sikeres törlés!";
                lblhibas.ForeColor = Color.Green;
                lblhibas.Visible = true;
            }

            BetoltJogositvanyok(soforId);
            hozzaadas = false;
            btnhozzaadas.Text = "Hozzáadás";
        }
    }
}
