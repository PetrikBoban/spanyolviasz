using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamonkeres20260317
{
    public partial class pizzeria : Form
    {

        public pizzeria()
        {
            InitializeComponent();

        }

        private void btnbevitel_Click(object sender, EventArgs e)
        {
            var f = new menulap();
            f.FormClosed += (s, args) =>
            {
                this.Show();
                this.Activate();
            };
            this.Hide();

            try
            {
                f.Show();
            }
            catch (Exception)
            {

                this.Show();
            }
            










        }
    }
}
