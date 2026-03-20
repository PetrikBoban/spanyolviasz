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
    public partial class menulap : Form
    {
       private List<string> nevlista = new List<string>();
        private List<int> kicsilista = new List<int>();
        private List<int> nagylista = new List<int>();
        public menulap()
        {
            InitializeComponent();
            OpenFileDialog ofd = new OpenFileDialog();
         

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] lines = System.IO.File.ReadAllLines(ofd.FileName);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] parts = lines[i].Split(';');
                        if (parts.Length == 3)
                        {
                            string nev = parts[0];
                            int kicsi = int.Parse(parts[1]);
                            int nagy = int.Parse(parts[2]);
                            nevlista.Add(nev);
                            kicsilista.Add(kicsi);
                            nagylista.Add(nagy);



                        }
                    }



                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba adatbevitel közben");
                this.Close();
            }
        }

        private void menulap_Load(object sender, EventArgs e)
        {
            richTextBox1.SendToBack();
            for (int i = 0; i < nevlista.Count; i++)
            {
                richTextBox1.AppendText($"\t{nevlista[i]}\t\t - Kicsi: {kicsilista[i]} Ft,\t\t Nagy: {nagylista[i]} Ft \t\t darab\n\n");
            }

            

           

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
