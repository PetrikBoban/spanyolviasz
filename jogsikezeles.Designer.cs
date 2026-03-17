namespace TollÚtdíj
{
    partial class jogsikezeles
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
            this.cbbsoforlista = new System.Windows.Forms.ComboBox();
            this.cbbkateg = new System.Windows.Forms.ComboBox();
            this.lblkateg = new System.Windows.Forms.Label();
            this.lblervtol = new System.Windows.Forms.Label();
            this.lblervig = new System.Windows.Forms.Label();
            this.btnvissza = new System.Windows.Forms.Button();
            this.btnmentes = new System.Windows.Forms.Button();
            this.btnhozzaadas = new System.Windows.Forms.Button();
            this.btntorles = new System.Windows.Forms.Button();
            this.lblhibas = new System.Windows.Forms.Label();
            this.dtpErvTol = new System.Windows.Forms.DateTimePicker();
            this.dtpErvIg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhibass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbsoforlista
            // 
            this.cbbsoforlista.FormattingEnabled = true;
            this.cbbsoforlista.Location = new System.Drawing.Point(10, 26);
            this.cbbsoforlista.Name = "cbbsoforlista";
            this.cbbsoforlista.Size = new System.Drawing.Size(121, 21);
            this.cbbsoforlista.TabIndex = 0;
            this.cbbsoforlista.SelectedIndexChanged += new System.EventHandler(this.cbbsoforlista_SelectedIndexChanged);
            // 
            // cbbkateg
            // 
            this.cbbkateg.FormattingEnabled = true;
            this.cbbkateg.Location = new System.Drawing.Point(200, 79);
            this.cbbkateg.Name = "cbbkateg";
            this.cbbkateg.Size = new System.Drawing.Size(58, 21);
            this.cbbkateg.TabIndex = 1;
            this.cbbkateg.SelectedIndexChanged += new System.EventHandler(this.cbbkateg_SelectedIndexChanged_1);
            // 
            // lblkateg
            // 
            this.lblkateg.AutoSize = true;
            this.lblkateg.Location = new System.Drawing.Point(133, 82);
            this.lblkateg.Name = "lblkateg";
            this.lblkateg.Size = new System.Drawing.Size(61, 13);
            this.lblkateg.TabIndex = 2;
            this.lblkateg.Text = "Kategóriák:";
            // 
            // lblervtol
            // 
            this.lblervtol.AutoSize = true;
            this.lblervtol.Location = new System.Drawing.Point(11, 120);
            this.lblervtol.Name = "lblervtol";
            this.lblervtol.Size = new System.Drawing.Size(112, 13);
            this.lblervtol.TabIndex = 5;
            this.lblervtol.Text = "Érvényesség kezdete:";
            // 
            // lblervig
            // 
            this.lblervig.AutoSize = true;
            this.lblervig.Location = new System.Drawing.Point(18, 157);
            this.lblervig.Name = "lblervig";
            this.lblervig.Size = new System.Drawing.Size(98, 13);
            this.lblervig.TabIndex = 6;
            this.lblervig.Text = "Érvényesség vége:";
            // 
            // btnvissza
            // 
            this.btnvissza.Location = new System.Drawing.Point(336, 259);
            this.btnvissza.Name = "btnvissza";
            this.btnvissza.Size = new System.Drawing.Size(75, 23);
            this.btnvissza.TabIndex = 7;
            this.btnvissza.Text = "Vissza";
            this.btnvissza.UseVisualStyleBackColor = true;
            this.btnvissza.Click += new System.EventHandler(this.btnvissza_Click);
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(129, 183);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(200, 28);
            this.btnmentes.TabIndex = 49;
            this.btnmentes.Text = "Változtatások mentése";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // btnhozzaadas
            // 
            this.btnhozzaadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhozzaadas.Location = new System.Drawing.Point(129, 217);
            this.btnhozzaadas.Name = "btnhozzaadas";
            this.btnhozzaadas.Size = new System.Drawing.Size(200, 24);
            this.btnhozzaadas.TabIndex = 48;
            this.btnhozzaadas.Text = "ÚJ kategória hozzáadás";
            this.btnhozzaadas.UseVisualStyleBackColor = true;
            this.btnhozzaadas.Click += new System.EventHandler(this.btnhozzaadas_Click);
            // 
            // btntorles
            // 
            this.btntorles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btntorles.BackColor = System.Drawing.Color.Red;
            this.btntorles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btntorles.Location = new System.Drawing.Point(264, 79);
            this.btntorles.Name = "btntorles";
            this.btntorles.Size = new System.Drawing.Size(65, 22);
            this.btntorles.TabIndex = 50;
            this.btntorles.Text = "Törlés";
            this.btntorles.UseVisualStyleBackColor = false;
            this.btntorles.Click += new System.EventHandler(this.btntorles_Click);
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Location = new System.Drawing.Point(16, 478);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(35, 13);
            this.lblhibas.TabIndex = 51;
            this.lblhibas.Text = "label1";
            this.lblhibas.Visible = false;
            // 
            // dtpErvTol
            // 
            this.dtpErvTol.Location = new System.Drawing.Point(129, 120);
            this.dtpErvTol.Name = "dtpErvTol";
            this.dtpErvTol.Size = new System.Drawing.Size(200, 20);
            this.dtpErvTol.TabIndex = 52;
            // 
            // dtpErvIg
            // 
            this.dtpErvIg.Location = new System.Drawing.Point(129, 157);
            this.dtpErvIg.Name = "dtpErvIg";
            this.dtpErvIg.Size = new System.Drawing.Size(200, 20);
            this.dtpErvIg.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Söfőrök:";
            // 
            // lblhibass
            // 
            this.lblhibass.AutoSize = true;
            this.lblhibass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibass.ForeColor = System.Drawing.Color.Red;
            this.lblhibass.Location = new System.Drawing.Point(7, 246);
            this.lblhibass.Name = "lblhibass";
            this.lblhibass.Size = new System.Drawing.Size(68, 16);
            this.lblhibass.TabIndex = 55;
            this.lblhibass.Text = "HIBA LABEL";
            this.lblhibass.Visible = false;
            // 
            // jogsikezeles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 294);
            this.Controls.Add(this.lblhibass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpErvIg);
            this.Controls.Add(this.dtpErvTol);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.btntorles);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.btnhozzaadas);
            this.Controls.Add(this.btnvissza);
            this.Controls.Add(this.lblervig);
            this.Controls.Add(this.lblervtol);
            this.Controls.Add(this.lblkateg);
            this.Controls.Add(this.cbbkateg);
            this.Controls.Add(this.cbbsoforlista);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 333);
            this.Name = "jogsikezeles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "jogsikezeles";
            this.Load += new System.EventHandler(this.jogsikezeles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbsoforlista;
        private System.Windows.Forms.ComboBox cbbkateg;
        private System.Windows.Forms.Label lblkateg;
        private System.Windows.Forms.Label lblervtol;
        private System.Windows.Forms.Label lblervig;
        private System.Windows.Forms.Button btnvissza;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.Button btnhozzaadas;
        private System.Windows.Forms.Button btntorles;
        private System.Windows.Forms.Label lblhibas;
        private System.Windows.Forms.DateTimePicker dtpErvTol;
        private System.Windows.Forms.DateTimePicker dtpErvIg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhibass;
    }
}