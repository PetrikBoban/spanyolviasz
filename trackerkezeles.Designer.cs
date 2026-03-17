namespace TollÚtdíj
{
    partial class trackerkezeles
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
            this.cbbaktiv = new System.Windows.Forms.ComboBox();
            this.lblimei = new System.Windows.Forms.Label();
            this.txbimei = new System.Windows.Forms.TextBox();
            this.lbltaktiv = new System.Windows.Forms.Label();
            this.lblfirm = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblsimicc = new System.Windows.Forms.Label();
            this.txbfirmware = new System.Windows.Forms.TextBox();
            this.txbmodell = new System.Windows.Forms.TextBox();
            this.txbsimiccid = new System.Windows.Forms.TextBox();
            this.cbbTrackerLista = new System.Windows.Forms.ComboBox();
            this.btnvissza = new System.Windows.Forms.Button();
            this.dtpletkezes = new System.Windows.Forms.DateTimePicker();
            this.lbletrehoz = new System.Windows.Forms.Label();
            this.lbleszkoz = new System.Windows.Forms.Label();
            this.lbljarmuadat = new System.Windows.Forms.Label();
            this.txbjarmu = new System.Windows.Forms.TextBox();
            this.lblhibas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbaktiv
            // 
            this.cbbaktiv.FormattingEnabled = true;
            this.cbbaktiv.Location = new System.Drawing.Point(108, 258);
            this.cbbaktiv.Name = "cbbaktiv";
            this.cbbaktiv.Size = new System.Drawing.Size(202, 21);
            this.cbbaktiv.TabIndex = 72;
            // 
            // lblimei
            // 
            this.lblimei.AutoSize = true;
            this.lblimei.Location = new System.Drawing.Point(74, 115);
            this.lblimei.Name = "lblimei";
            this.lblimei.Size = new System.Drawing.Size(28, 13);
            this.lblimei.TabIndex = 71;
            this.lblimei.Text = "imei:";
            // 
            // txbimei
            // 
            this.txbimei.Location = new System.Drawing.Point(108, 112);
            this.txbimei.Name = "txbimei";
            this.txbimei.Size = new System.Drawing.Size(202, 20);
            this.txbimei.TabIndex = 70;
            // 
            // lbltaktiv
            // 
            this.lbltaktiv.AutoSize = true;
            this.lbltaktiv.Location = new System.Drawing.Point(66, 261);
            this.lbltaktiv.Name = "lbltaktiv";
            this.lbltaktiv.Size = new System.Drawing.Size(36, 13);
            this.lbltaktiv.TabIndex = 65;
            this.lbltaktiv.Text = "Aktív:";
            // 
            // lblfirm
            // 
            this.lblfirm.AutoSize = true;
            this.lblfirm.Location = new System.Drawing.Point(19, 220);
            this.lblfirm.Name = "lblfirm";
            this.lblfirm.Size = new System.Drawing.Size(83, 13);
            this.lblfirm.TabIndex = 61;
            this.lblfirm.Text = "Firmware verzió:";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Location = new System.Drawing.Point(61, 185);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(41, 13);
            this.lblmodel.TabIndex = 60;
            this.lblmodel.Text = "Modell:";
            // 
            // lblsimicc
            // 
            this.lblsimicc.AutoSize = true;
            this.lblsimicc.Location = new System.Drawing.Point(41, 154);
            this.lblsimicc.Name = "lblsimicc";
            this.lblsimicc.Size = new System.Drawing.Size(61, 13);
            this.lblsimicc.TabIndex = 59;
            this.lblsimicc.Text = "simm_iccid:";
            // 
            // txbfirmware
            // 
            this.txbfirmware.Location = new System.Drawing.Point(108, 217);
            this.txbfirmware.Name = "txbfirmware";
            this.txbfirmware.Size = new System.Drawing.Size(202, 20);
            this.txbfirmware.TabIndex = 57;
            // 
            // txbmodell
            // 
            this.txbmodell.Location = new System.Drawing.Point(108, 182);
            this.txbmodell.Name = "txbmodell";
            this.txbmodell.Size = new System.Drawing.Size(202, 20);
            this.txbmodell.TabIndex = 56;
            // 
            // txbsimiccid
            // 
            this.txbsimiccid.Location = new System.Drawing.Point(108, 147);
            this.txbsimiccid.Name = "txbsimiccid";
            this.txbsimiccid.Size = new System.Drawing.Size(202, 20);
            this.txbsimiccid.TabIndex = 55;
            // 
            // cbbTrackerLista
            // 
            this.cbbTrackerLista.FormattingEnabled = true;
            this.cbbTrackerLista.Location = new System.Drawing.Point(34, 29);
            this.cbbTrackerLista.Name = "cbbTrackerLista";
            this.cbbTrackerLista.Size = new System.Drawing.Size(276, 21);
            this.cbbTrackerLista.TabIndex = 54;
            this.cbbTrackerLista.SelectedIndexChanged += new System.EventHandler(this.cbbTrackerLista_SelectedIndexChanged);
            // 
            // btnvissza
            // 
            this.btnvissza.Location = new System.Drawing.Point(319, 336);
            this.btnvissza.Name = "btnvissza";
            this.btnvissza.Size = new System.Drawing.Size(75, 23);
            this.btnvissza.TabIndex = 52;
            this.btnvissza.Text = "Vissza";
            this.btnvissza.UseVisualStyleBackColor = true;
            this.btnvissza.Click += new System.EventHandler(this.btnvissza_Click);
            // 
            // dtpletkezes
            // 
            this.dtpletkezes.Location = new System.Drawing.Point(108, 300);
            this.dtpletkezes.Name = "dtpletkezes";
            this.dtpletkezes.Size = new System.Drawing.Size(202, 20);
            this.dtpletkezes.TabIndex = 74;
            // 
            // lbletrehoz
            // 
            this.lbletrehoz.AutoSize = true;
            this.lbletrehoz.Location = new System.Drawing.Point(0, 300);
            this.lbletrehoz.Name = "lbletrehoz";
            this.lbletrehoz.Size = new System.Drawing.Size(102, 13);
            this.lbletrehoz.TabIndex = 75;
            this.lbletrehoz.Text = "Létrehozás Dátuma:";
            // 
            // lbleszkoz
            // 
            this.lbleszkoz.AutoSize = true;
            this.lbleszkoz.Location = new System.Drawing.Point(114, 13);
            this.lbleszkoz.Name = "lbleszkoz";
            this.lbleszkoz.Size = new System.Drawing.Size(95, 13);
            this.lbleszkoz.TabIndex = 76;
            this.lbleszkoz.Text = "Tracker eszközök:";
            // 
            // lbljarmuadat
            // 
            this.lbljarmuadat.AutoSize = true;
            this.lbljarmuadat.Location = new System.Drawing.Point(32, 86);
            this.lbljarmuadat.Name = "lbljarmuadat";
            this.lbljarmuadat.Size = new System.Drawing.Size(70, 13);
            this.lbljarmuadat.TabIndex = 77;
            this.lbljarmuadat.Text = "Jármű adatai:";
            // 
            // txbjarmu
            // 
            this.txbjarmu.Location = new System.Drawing.Point(108, 83);
            this.txbjarmu.Name = "txbjarmu";
            this.txbjarmu.Size = new System.Drawing.Size(202, 20);
            this.txbjarmu.TabIndex = 78;
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibas.ForeColor = System.Drawing.Color.Red;
            this.lblhibas.Location = new System.Drawing.Point(12, 325);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(68, 16);
            this.lblhibas.TabIndex = 79;
            this.lblhibas.Text = "HIBA LABEL";
            this.lblhibas.Visible = false;
            // 
            // trackerkezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 360);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.txbjarmu);
            this.Controls.Add(this.lbljarmuadat);
            this.Controls.Add(this.lbleszkoz);
            this.Controls.Add(this.lbletrehoz);
            this.Controls.Add(this.dtpletkezes);
            this.Controls.Add(this.cbbaktiv);
            this.Controls.Add(this.lblimei);
            this.Controls.Add(this.txbimei);
            this.Controls.Add(this.lbltaktiv);
            this.Controls.Add(this.lblfirm);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblsimicc);
            this.Controls.Add(this.txbfirmware);
            this.Controls.Add(this.txbmodell);
            this.Controls.Add(this.txbsimiccid);
            this.Controls.Add(this.cbbTrackerLista);
            this.Controls.Add(this.btnvissza);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 399);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(412, 399);
            this.Name = "trackerkezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trackerkezeles";
            this.Load += new System.EventHandler(this.trackerkezeles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbaktiv;
        private System.Windows.Forms.Label lblimei;
        private System.Windows.Forms.TextBox txbimei;
        private System.Windows.Forms.Label lbltaktiv;
        private System.Windows.Forms.Label lblfirm;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblsimicc;
        private System.Windows.Forms.TextBox txbfirmware;
        private System.Windows.Forms.TextBox txbmodell;
        private System.Windows.Forms.TextBox txbsimiccid;
        private System.Windows.Forms.ComboBox cbbTrackerLista;
        private System.Windows.Forms.Button btnvissza;
        private System.Windows.Forms.DateTimePicker dtpletkezes;
        private System.Windows.Forms.Label lbletrehoz;
        private System.Windows.Forms.Label lbleszkoz;
        private System.Windows.Forms.Label lbljarmuadat;
        private System.Windows.Forms.TextBox txbjarmu;
        private System.Windows.Forms.Label lblhibas;
    }
}