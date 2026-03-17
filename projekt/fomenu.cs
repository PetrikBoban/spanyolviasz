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
    public partial class userinterface : Form
    {
        private string role;
        private int cegId;
        public userinterface(string role, int cegId)
        {
            InitializeComponent();
            this.role = role;
            this.cegId = cegId;
            lblhibas.Visible = false;


            if (role == "operator")
            {
                this.Text = "TollÚtdíj - Operátor";
                btncegkezeles.Enabled = false;
                btnjarmukez.Enabled = false;
                btnjogsik.Enabled = false;
            }
            else if (role == "ceg_admin")
            {
                this.Text = "TollÚtdíj - Adminisztrátor";
            }
            else if (role == "rendszer_admin")
            {
                this.Text = "TollÚtdíj - Rendszer adminisztrátor";
            }
        }


        private void userinterface_Load(object sender, EventArgs e)
        {

        }
        private void btnlogout_Click_1(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.SessionToken = "";
            Properties.Settings.Default.Save();
            this.Hide();
            Login login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();

            
        }

        private void btncegkezeles_Click(object sender, EventArgs e)
        {
            var f = new cegkezeles(role, cegId);

            
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };

            this.Hide();
            f.Show();
        }

        private void btnjarmukez_Click(object sender, EventArgs e)
        {
            var f = new jarmukezeles(role, cegId);
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };

            this.Hide();
            f.Show();
        }

        private void btnsofor_Click(object sender, EventArgs e)
        {
            var f = new soforkezeles(role, cegId);
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };

            this.Hide();
            f.Show();
        }

        private void btnjogsik_Click(object sender, EventArgs e)
        {
            var f = new jogsikezeles(role, cegId);
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };

            this.Hide();
            f.Show();
        }

        private void btntrackkez_Click(object sender, EventArgs e)
        {
            var f = new trackerkezeles(role, cegId);
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };

            this.Hide();
            f.Show();
        }
    }
}
