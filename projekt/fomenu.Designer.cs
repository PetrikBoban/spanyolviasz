namespace TollÚtdíj
{
    partial class userinterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userinterface));
            this.btncegkezeles = new System.Windows.Forms.Button();
            this.btnjarmukez = new System.Windows.Forms.Button();
            this.btnjogsik = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntrackkez = new System.Windows.Forms.Button();
            this.btnsofor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhibas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncegkezeles
            // 
            this.btncegkezeles.Location = new System.Drawing.Point(37, 20);
            this.btncegkezeles.Name = "btncegkezeles";
            this.btncegkezeles.Size = new System.Drawing.Size(130, 23);
            this.btncegkezeles.TabIndex = 0;
            this.btncegkezeles.Text = "Cég áttekintése";
            this.btncegkezeles.UseCompatibleTextRendering = true;
            this.btncegkezeles.UseVisualStyleBackColor = true;
            this.btncegkezeles.Click += new System.EventHandler(this.btncegkezeles_Click);
            // 
            // btnjarmukez
            // 
            this.btnjarmukez.Location = new System.Drawing.Point(37, 60);
            this.btnjarmukez.Name = "btnjarmukez";
            this.btnjarmukez.Size = new System.Drawing.Size(130, 23);
            this.btnjarmukez.TabIndex = 1;
            this.btnjarmukez.Text = "Járművek kezelése";
            this.btnjarmukez.UseVisualStyleBackColor = true;
            this.btnjarmukez.Click += new System.EventHandler(this.btnjarmukez_Click);
            // 
            // btnjogsik
            // 
            this.btnjogsik.Location = new System.Drawing.Point(37, 140);
            this.btnjogsik.Name = "btnjogsik";
            this.btnjogsik.Size = new System.Drawing.Size(130, 23);
            this.btnjogsik.TabIndex = 2;
            this.btnjogsik.Text = "Jogosítványok kezelése";
            this.btnjogsik.UseVisualStyleBackColor = true;
            this.btnjogsik.Click += new System.EventHandler(this.btnjogsik_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(12, 226);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(97, 23);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Kijelentkezés";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(81, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(81, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btntrackkez
            // 
            this.btntrackkez.Location = new System.Drawing.Point(37, 180);
            this.btntrackkez.Name = "btntrackkez";
            this.btntrackkez.Size = new System.Drawing.Size(130, 23);
            this.btntrackkez.TabIndex = 15;
            this.btntrackkez.Text = "Trackerek megtekintése";
            this.btntrackkez.UseVisualStyleBackColor = true;
            this.btntrackkez.Click += new System.EventHandler(this.btntrackkez_Click);
            // 
            // btnsofor
            // 
            this.btnsofor.Location = new System.Drawing.Point(37, 100);
            this.btnsofor.Name = "btnsofor";
            this.btnsofor.Size = new System.Drawing.Size(130, 23);
            this.btnsofor.TabIndex = 16;
            this.btnsofor.Text = "Sofőrök kezelése";
            this.btnsofor.UseVisualStyleBackColor = true;
            this.btnsofor.Click += new System.EventHandler(this.btnsofor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibas.ForeColor = System.Drawing.Color.Red;
            this.lblhibas.Location = new System.Drawing.Point(175, 223);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(68, 16);
            this.lblhibas.TabIndex = 18;
            this.lblhibas.Text = "HIBA LABEL";
            this.lblhibas.Visible = false;
            // 
            // userinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsofor);
            this.Controls.Add(this.btntrackkez);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnjogsik);
            this.Controls.Add(this.btnjarmukez);
            this.Controls.Add(this.btncegkezeles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "userinterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TollÚtdíj";
            this.Load += new System.EventHandler(this.userinterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncegkezeles;
        private System.Windows.Forms.Button btnjarmukez;
        private System.Windows.Forms.Button btnjogsik;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntrackkez;
        private System.Windows.Forms.Button btnsofor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhibas;
    }
}