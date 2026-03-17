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
    public partial class trackerkezeles : Form
    {

        private readonly string role;
        private readonly int cegId;

        public trackerkezeles(string role, int cegId)
        {
            InitializeComponent();
            this.role = role;
            this.cegId = cegId;
            cbbaktiv.Items.Clear();
            cbbaktiv.Items.Add("Inaktív"); 
            cbbaktiv.Items.Add("Aktív");   
            cbbaktiv.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTrackerLista.DropDownStyle = ComboBoxStyle.DropDownList;
            txbfirmware.Enabled = false;
            txbimei.Enabled = false;
            txbsimiccid.Enabled = false;
            txbmodell.Enabled = false;
            cbbaktiv.Enabled = false;
            dtpletkezes.Enabled = false;
            txbjarmu.Enabled = false;
            lblhibas.Visible = false;
        }

        private void trackerkezeles_Load(object sender, EventArgs e)
        {
            BetoltTrackerLista();

            if (role == "operator")
            {
                this.Text = "Trackerek megtekintése - Operátor";
            }
            else if (role == "ceg_admin")
            {
                this.Text = "Trackerek megtekintése - Adminisztrátor";

            }
            else if (role == "rendszer_admin")
            {
                this.Text = "Trackerek megtekintése - Rendszer adminisztrátor";
               
            }
        }

        private void BetoltTrackerLista()
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

                var cmd = kapcsolat.CreateCommand();
                cmd.CommandText = @"
SELECT
  t.modell,
  j.rendszam
FROM jarmuvek j
INNER JOIN trackereszkozok t ON j.device_id = t.id
WHERE j.ceg_id = @cegId
ORDER BY j.rendszam;
";
                cmd.Parameters.AddWithValue("@cegId", cegId);

                using (var reader = cmd.ExecuteReader())
                {
                    cbbTrackerLista.Items.Clear();

                    while (reader.Read())
                    {
                        string megjelenites = $"{reader["modell"]} | {reader["rendszam"]}";
                        cbbTrackerLista.Items.Add(megjelenites);
                    }

                    if (cbbTrackerLista.Items.Count > 0)
                        cbbTrackerLista.SelectedIndex = 0;
                }
            }
        }


        private void btnvissza_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BetoltTrackerAdatok(string rendszam)
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

                var cmd = kapcsolat.CreateCommand();
                cmd.CommandText = @"
SELECT
  t.imei,
  t.sim_iccid,
  t.modell,
  t.firmware_verzio,
  t.aktiv,
  t.created_at,
  j.marka,
  j.tipus,
  j.rendszam
FROM jarmuvek j
INNER JOIN trackereszkozok t ON j.device_id = t.id
WHERE j.rendszam = @rendszam
  AND j.ceg_id = @cegId
LIMIT 1;
";
                cmd.Parameters.AddWithValue("@rendszam", rendszam);
                cmd.Parameters.AddWithValue("@cegId", cegId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return;


                    txbimei.Text = reader["imei"].ToString();
                    txbsimiccid.Text = reader["sim_iccid"].ToString();
                    txbmodell.Text = reader["modell"].ToString();
                    txbfirmware.Text = reader["firmware_verzio"].ToString();
                    cbbaktiv.SelectedItem = Convert.ToInt32(reader["aktiv"]) == 1 ? "Aktív" : "Inaktív";
                    dtpletkezes.Value = Convert.ToDateTime(reader["created_at"]);
                    txbjarmu.Text = $"{reader["marka"]} {reader["tipus"]} ({reader["rendszam"]})";
                }
            }
        }

        private void cbbTrackerLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTrackerLista.SelectedItem == null)
                return;

            string szoveg = cbbTrackerLista.SelectedItem.ToString();

            // "Modell | Rendszam"
            string rendszam = szoveg.Split('|').Last().Trim();

            BetoltTrackerAdatok(rendszam);
        }
    }
}
