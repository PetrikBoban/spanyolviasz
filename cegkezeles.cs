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
    public partial class cegkezeles : Form
    {
        private readonly string role;
        private readonly int cegId;
        public cegkezeles(string role, int cegId)
        {
            
        InitializeComponent();



            lblhibas.Visible = false;
            this.role = role;
            this.cegId = cegId;
            cbbceglista.DropDownStyle = ComboBoxStyle.DropDownList;
            txbcegnev.Multiline = true;
            txbcegnev.AutoSize = true;
            txbcegnev.ScrollBars = ScrollBars.None;
            txbcegcim.Multiline = true;
            txbcegcim.AutoSize = true;
            txbcegcim.ScrollBars = ScrollBars.None;
            txbcegszam.Multiline = true;
            txbcegszam.AutoSize = true;
            txbcegszam.ScrollBars = ScrollBars.None;

            if (role == "operator")
            {
                this.Text = "Cégkezelés - Operátor";
                txbcegcim.Enabled = false;
                txbcegnev.Enabled = false;
                txbcegszam.Enabled = false;
                btnmentes.Visible = false;
                cbbceglista.Enabled = false;
                
            }
            else if (role == "ceg_admin")
            {
                this.Text = "Cégkezelés - Adminisztrátor";
                cbbceglista.Enabled = false;
            }
            else if (role == "rendszer_admin")
            {
                this.Text = "Cégkezelés - Rendszer adminisztrátor";
            }
        }

        private void CegAdatokBetoltese(string cegNev)
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
                    MessageBox.Show("Adatlekérdezési hiba.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
            SELECT nev, cim, adoszam
            FROM cegek
            WHERE nev = @nev
            LIMIT 1";

                parancs.Parameters.AddWithValue("@nev", cegNev);

                using (var reader = parancs.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txbcegnev.Text = reader["nev"].ToString();
                        txbcegcim.Text = reader["cim"].ToString();
                        txbcegszam.Text = reader["adoszam"].ToString();
                    }
                }

                txbcegcim.Visible = true;
                txbcegnev.Visible = true;
                txbcegszam.Visible = true;
                lbladatok.Visible = true;
                btnmentes.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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
                catch (Exception)
                {
                    lblhibas.Text = "Adatbetöltési hiba.\r\nEllenőrizze az internetkapcsolatot, majd próbálja újra.";
                    lblhibas.ForeColor = Color.Red;
                    lblhibas.Visible = true;
                    return;
                }

                var parancs = kapcsolat.CreateCommand();
                if (role == "ceg_admin")
                {
                    parancs.CommandText = @"
                SELECT c.nev
                FROM cegek c
                JOIN felhasznalok f ON f.ceg_id = c.id
                WHERE f.ceg_id = @cegId
                  AND f.role = 'ceg_admin'
                LIMIT 1";
                    parancs.Parameters.AddWithValue("@cegId", cegId);
                }
                else if (role == "rendszer_admin")
                {
                    parancs.CommandText = @"
                SELECT nev
                FROM cegek
                WHERE statusz = 'aktiv'";
                }
                else
                {
                   
                    parancs.CommandText = @"
                SELECT nev
                FROM cegek
                WHERE id = @cegId";
                    parancs.Parameters.AddWithValue("@cegId", cegId);
                }

                using (var reader = parancs.ExecuteReader())
                {
                    while (reader.Read())
                    {
                      
                        cbbceglista.Items.Add(reader.GetString("nev"));
                        cbbceglista.SelectedIndex = 0;

                    }
                }


            }
        }

        


        private void btnvissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void btnmentes_Click(object sender, EventArgs e)
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
                    lblhibas.Text = "Nem sikerült csatlakozni az adatbázishoz.";
                    lblhibas.ForeColor = Color.Red;
                    lblhibas.Visible = true;
                    return;
                }

                var parancs = kapcsolat.CreateCommand();
                parancs.CommandText = @"
            UPDATE cegek
            SET nev = @nev,
                cim = @cim,
                adoszam = @adoszam
            WHERE id = @cegId";

                parancs.Parameters.AddWithValue("@nev", txbcegnev.Text.Trim());
                parancs.Parameters.AddWithValue("@cim", txbcegcim.Text.Trim());
                parancs.Parameters.AddWithValue("@adoszam", txbcegszam.Text.Trim());
                parancs.Parameters.AddWithValue("@cegId", cegId);
                try
                {
                    parancs.ExecuteNonQuery();
                    lblhibas.Text = "Sikeres mentés!";
                    lblhibas.ForeColor = Color.Green;
                    
                    lblhibas.Visible = true;
                }
                catch (Exception ex)
                {
                    lblhibas.Text = "Hiba mentés közben:\n" + ex.Message;
                    lblhibas.ForeColor = Color.Red;
                    lblhibas.Visible = true;
                }
            }
        }

        private void cbbceglista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbceglista.SelectedItem == null)
                return;

            string cegNev = cbbceglista.SelectedItem.ToString();
            CegAdatokBetoltese(cegNev);
        }
    }
}
