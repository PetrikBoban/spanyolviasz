namespace TollÚtdíj
{
    partial class cegkezeles
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
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblhibass = new System.Windows.Forms.Label();
            this.btnmentes = new System.Windows.Forms.Button();
            this.txbcegnev = new System.Windows.Forms.TextBox();
            this.txbcegszam = new System.Windows.Forms.TextBox();
            this.txbcegcim = new System.Windows.Forms.TextBox();
            this.lbladatok = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbceglista = new System.Windows.Forms.ComboBox();
            this.lblhibas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnvissza
            // 
            this.btnvissza.Location = new System.Drawing.Point(460, 261);
            this.btnvissza.Name = "btnvissza";
            this.btnvissza.Size = new System.Drawing.Size(75, 23);
            this.btnvissza.TabIndex = 3;
            this.btnvissza.Text = "Vissza";
            this.btnvissza.UseVisualStyleBackColor = true;
            this.btnvissza.Click += new System.EventHandler(this.btnvissza_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblinfo.Location = new System.Drawing.Point(6, 252);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(354, 40);
            this.lblinfo.TabIndex = 11;
            this.lblinfo.Text = "ⓘ Amennyiben új céget szeretne létrehozni,\r\n a webes felületen van lehetősége ezt" +
    " megteheti!";
            // 
            // lblhibass
            // 
            this.lblhibass.AutoSize = true;
            this.lblhibass.Location = new System.Drawing.Point(12, 9);
            this.lblhibass.Name = "lblhibass";
            this.lblhibass.Size = new System.Drawing.Size(0, 13);
            this.lblhibass.TabIndex = 0;
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(89, 195);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(101, 38);
            this.btnmentes.TabIndex = 2;
            this.btnmentes.Text = "Változtatások mentése";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // txbcegnev
            // 
            this.txbcegnev.Location = new System.Drawing.Point(75, 73);
            this.txbcegnev.Name = "txbcegnev";
            this.txbcegnev.Size = new System.Drawing.Size(134, 20);
            this.txbcegnev.TabIndex = 4;
            // 
            // txbcegszam
            // 
            this.txbcegszam.Location = new System.Drawing.Point(75, 114);
            this.txbcegszam.Name = "txbcegszam";
            this.txbcegszam.Size = new System.Drawing.Size(134, 20);
            this.txbcegszam.TabIndex = 5;
            // 
            // txbcegcim
            // 
            this.txbcegcim.Location = new System.Drawing.Point(75, 155);
            this.txbcegcim.Name = "txbcegcim";
            this.txbcegcim.Size = new System.Drawing.Size(134, 20);
            this.txbcegcim.TabIndex = 6;
            // 
            // lbladatok
            // 
            this.lbladatok.AutoSize = true;
            this.lbladatok.Location = new System.Drawing.Point(116, 54);
            this.lbladatok.Name = "lbladatok";
            this.lbladatok.Size = new System.Drawing.Size(44, 13);
            this.lbladatok.TabIndex = 7;
            this.lbladatok.Text = "Adatok:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Cégnév:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adószám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cím:";
            // 
            // cbbceglista
            // 
            this.cbbceglista.FormattingEnabled = true;
            this.cbbceglista.Location = new System.Drawing.Point(10, 12);
            this.cbbceglista.Name = "cbbceglista";
            this.cbbceglista.Size = new System.Drawing.Size(199, 21);
            this.cbbceglista.TabIndex = 12;
            this.cbbceglista.SelectedIndexChanged += new System.EventHandler(this.cbbceglista_SelectedIndexChanged);
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibas.ForeColor = System.Drawing.Color.Red;
            this.lblhibas.Location = new System.Drawing.Point(229, 17);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(68, 16);
            this.lblhibas.TabIndex = 15;
            this.lblhibas.Text = "HIBA LABEL";
            this.lblhibas.Visible = false;
            // 
            // cegkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.cbbceglista);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbladatok);
            this.Controls.Add(this.txbcegcim);
            this.Controls.Add(this.txbcegszam);
            this.Controls.Add(this.txbcegnev);
            this.Controls.Add(this.btnvissza);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.lblhibass);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "cegkezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cégek kezelése";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnvissza;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblhibass;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.TextBox txbcegnev;
        private System.Windows.Forms.TextBox txbcegszam;
        private System.Windows.Forms.TextBox txbcegcim;
        private System.Windows.Forms.Label lbladatok;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbceglista;
        private System.Windows.Forms.Label lblhibas;
    }
}