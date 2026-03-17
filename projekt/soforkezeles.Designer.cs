namespace TollÚtdíj
{
    partial class soforkezeles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnvissza = new System.Windows.Forms.Button();
            this.cbbsoforlista = new System.Windows.Forms.ComboBox();
            this.lblcegid = new System.Windows.Forms.Label();
            this.txbcegid = new System.Windows.Forms.TextBox();
            this.lbltaktiv = new System.Windows.Forms.Label();
            this.lbladoszam = new System.Windows.Forms.Label();
            this.txbadoszam = new System.Windows.Forms.TextBox();
            this.lblcim = new System.Windows.Forms.Label();
            this.lbltelszam = new System.Windows.Forms.Label();
            this.lblszemazon = new System.Windows.Forms.Label();
            this.lblszul = new System.Windows.Forms.Label();
            this.txbcim = new System.Windows.Forms.TextBox();
            this.txbtelszam = new System.Windows.Forms.TextBox();
            this.txbszemazon = new System.Windows.Forms.TextBox();
            this.txbszul = new System.Windows.Forms.TextBox();
            this.btnhozzaadas = new System.Windows.Forms.Button();
            this.btnmentes = new System.Windows.Forms.Button();
            this.lblnev = new System.Windows.Forms.Label();
            this.txbnev = new System.Windows.Forms.TextBox();
            this.cbbaktiv = new System.Windows.Forms.ComboBox();
            this.btntorles = new System.Windows.Forms.Button();
            this.lblhibas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvissza
            // 
            this.btnvissza.Location = new System.Drawing.Point(325, 415);
            this.btnvissza.Name = "btnvissza";
            this.btnvissza.Size = new System.Drawing.Size(75, 23);
            this.btnvissza.TabIndex = 0;
            this.btnvissza.Text = "Vissza";
            this.btnvissza.UseVisualStyleBackColor = true;
            this.btnvissza.Click += new System.EventHandler(this.btnvissza_Click);
            // 
            // cbbsoforlista
            // 
            this.cbbsoforlista.FormattingEnabled = true;
            this.cbbsoforlista.Location = new System.Drawing.Point(63, 37);
            this.cbbsoforlista.Name = "cbbsoforlista";
            this.cbbsoforlista.Size = new System.Drawing.Size(121, 21);
            this.cbbsoforlista.TabIndex = 2;
            this.cbbsoforlista.SelectedIndexChanged += new System.EventHandler(this.cbbsoforlista_SelectedIndexChanged);
            // 
            // lblcegid
            // 
            this.lblcegid.AutoSize = true;
            this.lblcegid.Location = new System.Drawing.Point(112, 335);
            this.lblcegid.Name = "lblcegid";
            this.lblcegid.Size = new System.Drawing.Size(36, 13);
            this.lblcegid.TabIndex = 45;
            this.lblcegid.Text = "cegid:";
            // 
            // txbcegid
            // 
            this.txbcegid.Location = new System.Drawing.Point(154, 332);
            this.txbcegid.Name = "txbcegid";
            this.txbcegid.Size = new System.Drawing.Size(134, 20);
            this.txbcegid.TabIndex = 44;
            // 
            // lbltaktiv
            // 
            this.lbltaktiv.AutoSize = true;
            this.lbltaktiv.Location = new System.Drawing.Point(112, 298);
            this.lbltaktiv.Name = "lbltaktiv";
            this.lbltaktiv.Size = new System.Drawing.Size(36, 13);
            this.lbltaktiv.TabIndex = 43;
            this.lbltaktiv.Text = "Aktív:";
            // 
            // lbladoszam
            // 
            this.lbladoszam.AutoSize = true;
            this.lbladoszam.Location = new System.Drawing.Point(95, 260);
            this.lbladoszam.Name = "lbladoszam";
            this.lbladoszam.Size = new System.Drawing.Size(53, 13);
            this.lbladoszam.TabIndex = 42;
            this.lbladoszam.Text = "Adószám:";
            // 
            // txbadoszam
            // 
            this.txbadoszam.Location = new System.Drawing.Point(154, 260);
            this.txbadoszam.Name = "txbadoszam";
            this.txbadoszam.Size = new System.Drawing.Size(134, 20);
            this.txbadoszam.TabIndex = 40;
            // 
            // lblcim
            // 
            this.lblcim.AutoSize = true;
            this.lblcim.Location = new System.Drawing.Point(112, 228);
            this.lblcim.Name = "lblcim";
            this.lblcim.Size = new System.Drawing.Size(29, 13);
            this.lblcim.TabIndex = 39;
            this.lblcim.Text = "Cím:";
            // 
            // lbltelszam
            // 
            this.lbltelszam.AutoSize = true;
            this.lbltelszam.Location = new System.Drawing.Point(81, 197);
            this.lbltelszam.Name = "lbltelszam";
            this.lbltelszam.Size = new System.Drawing.Size(70, 13);
            this.lbltelszam.TabIndex = 38;
            this.lbltelszam.Text = "Telefonszám:";
            // 
            // lblszemazon
            // 
            this.lblszemazon.AutoSize = true;
            this.lblszemazon.Location = new System.Drawing.Point(50, 162);
            this.lblszemazon.Name = "lblszemazon";
            this.lblszemazon.Size = new System.Drawing.Size(101, 13);
            this.lblszemazon.TabIndex = 37;
            this.lblszemazon.Text = "Személyi azonosító:";
            // 
            // lblszul
            // 
            this.lblszul.AutoSize = true;
            this.lblszul.Location = new System.Drawing.Point(67, 127);
            this.lblszul.Name = "lblszul";
            this.lblszul.Size = new System.Drawing.Size(84, 13);
            this.lblszul.TabIndex = 36;
            this.lblszul.Text = "Születési dátum:";
            // 
            // txbcim
            // 
            this.txbcim.Location = new System.Drawing.Point(154, 225);
            this.txbcim.Name = "txbcim";
            this.txbcim.Size = new System.Drawing.Size(134, 20);
            this.txbcim.TabIndex = 35;
            // 
            // txbtelszam
            // 
            this.txbtelszam.Location = new System.Drawing.Point(154, 190);
            this.txbtelszam.Name = "txbtelszam";
            this.txbtelszam.Size = new System.Drawing.Size(134, 20);
            this.txbtelszam.TabIndex = 34;
            // 
            // txbszemazon
            // 
            this.txbszemazon.Location = new System.Drawing.Point(154, 155);
            this.txbszemazon.Name = "txbszemazon";
            this.txbszemazon.Size = new System.Drawing.Size(134, 20);
            this.txbszemazon.TabIndex = 33;
            // 
            // txbszul
            // 
            this.txbszul.Location = new System.Drawing.Point(154, 120);
            this.txbszul.Name = "txbszul";
            this.txbszul.Size = new System.Drawing.Size(134, 20);
            this.txbszul.TabIndex = 32;
            // 
            // btnhozzaadas
            // 
            this.btnhozzaadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnhozzaadas.Location = new System.Drawing.Point(191, 358);
            this.btnhozzaadas.Name = "btnhozzaadas";
            this.btnhozzaadas.Size = new System.Drawing.Size(133, 38);
            this.btnhozzaadas.TabIndex = 46;
            this.btnhozzaadas.Text = "Új Sofőr hozzáadása";
            this.btnhozzaadas.UseVisualStyleBackColor = true;
            this.btnhozzaadas.Click += new System.EventHandler(this.btnhozzaadas_Click);
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(84, 358);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(101, 38);
            this.btnmentes.TabIndex = 47;
            this.btnmentes.Text = "Változtatások mentése";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // lblnev
            // 
            this.lblnev.AutoSize = true;
            this.lblnev.Location = new System.Drawing.Point(111, 88);
            this.lblnev.Name = "lblnev";
            this.lblnev.Size = new System.Drawing.Size(30, 13);
            this.lblnev.TabIndex = 49;
            this.lblnev.Text = "Név:";
            // 
            // txbnev
            // 
            this.txbnev.Location = new System.Drawing.Point(154, 85);
            this.txbnev.Name = "txbnev";
            this.txbnev.Size = new System.Drawing.Size(134, 20);
            this.txbnev.TabIndex = 48;
            // 
            // cbbaktiv
            // 
            this.cbbaktiv.FormattingEnabled = true;
            this.cbbaktiv.Location = new System.Drawing.Point(154, 298);
            this.cbbaktiv.Name = "cbbaktiv";
            this.cbbaktiv.Size = new System.Drawing.Size(134, 21);
            this.cbbaktiv.TabIndex = 50;
            // 
            // btntorles
            // 
            this.btntorles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntorles.Location = new System.Drawing.Point(191, 37);
            this.btntorles.Name = "btntorles";
            this.btntorles.Size = new System.Drawing.Size(98, 33);
            this.btntorles.TabIndex = 51;
            this.btntorles.Text = "Törlés";
            this.btntorles.UseVisualStyleBackColor = true;
            this.btntorles.Click += new System.EventHandler(this.btntorles_Click);
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibas.ForeColor = System.Drawing.Color.Red;
            this.lblhibas.Location = new System.Drawing.Point(12, 401);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(68, 16);
            this.lblhibas.TabIndex = 52;
            this.lblhibas.Text = "HIBA LABEL";
            this.lblhibas.Visible = false;
            // 
            // soforkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.btntorles);
            this.Controls.Add(this.cbbaktiv);
            this.Controls.Add(this.lblnev);
            this.Controls.Add(this.txbnev);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.btnhozzaadas);
            this.Controls.Add(this.lblcegid);
            this.Controls.Add(this.txbcegid);
            this.Controls.Add(this.lbltaktiv);
            this.Controls.Add(this.lbladoszam);
            this.Controls.Add(this.txbadoszam);
            this.Controls.Add(this.lblcim);
            this.Controls.Add(this.lbltelszam);
            this.Controls.Add(this.lblszemazon);
            this.Controls.Add(this.lblszul);
            this.Controls.Add(this.txbcim);
            this.Controls.Add(this.txbtelszam);
            this.Controls.Add(this.txbszemazon);
            this.Controls.Add(this.txbszul);
            this.Controls.Add(this.cbbsoforlista);
            this.Controls.Add(this.btnvissza);
            this.MaximumSize = new System.Drawing.Size(447, 489);
            this.MinimumSize = new System.Drawing.Size(447, 489);
            this.Name = "soforkezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "soforkezeles";
            this.Load += new System.EventHandler(this.soforkezeles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvissza;
        private System.Windows.Forms.ComboBox cbbsoforlista;
        private System.Windows.Forms.Label lblcegid;
        private System.Windows.Forms.TextBox txbcegid;
        private System.Windows.Forms.Label lbltaktiv;
        private System.Windows.Forms.Label lbladoszam;
        private System.Windows.Forms.TextBox txbadoszam;
        private System.Windows.Forms.Label lblcim;
        private System.Windows.Forms.Label lbltelszam;
        private System.Windows.Forms.Label lblszemazon;
        private System.Windows.Forms.Label lblszul;
        private System.Windows.Forms.TextBox txbcim;
        private System.Windows.Forms.TextBox txbtelszam;
        private System.Windows.Forms.TextBox txbszemazon;
        private System.Windows.Forms.TextBox txbszul;
        private System.Windows.Forms.Button btnhozzaadas;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.Label lblnev;
        private System.Windows.Forms.TextBox txbnev;
        private System.Windows.Forms.ComboBox cbbaktiv;
        private System.Windows.Forms.Button btntorles;
        private System.Windows.Forms.Label lblhibas;
    }
}