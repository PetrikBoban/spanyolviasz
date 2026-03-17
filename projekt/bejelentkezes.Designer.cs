using System.Net.NetworkInformation;

namespace TollÚtdíj
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.txbpass = new System.Windows.Forms.TextBox();
            this.txbusername = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblhibas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkrememberme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(31, 129);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(39, 13);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Jelszó:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(11, 78);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(59, 13);
            this.lbluser.TabIndex = 11;
            this.lbluser.Text = "E-mail cím:";
            // 
            // txbpass
            // 
            this.txbpass.BackColor = System.Drawing.SystemColors.Window;
            this.txbpass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txbpass.Location = new System.Drawing.Point(76, 126);
            this.txbpass.MaxLength = 25;
            this.txbpass.Name = "txbpass";
            this.txbpass.PasswordChar = '*';
            this.txbpass.Size = new System.Drawing.Size(114, 20);
            this.txbpass.TabIndex = 10;
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(77, 75);
            this.txbusername.MaxLength = 25;
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(113, 20);
            this.txbusername.TabIndex = 9;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(73, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 13);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Kérjük jelentkezzen be!";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(76, 174);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(114, 23);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Bejelentkezés";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // lblhibas
            // 
            this.lblhibas.AutoSize = true;
            this.lblhibas.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhibas.ForeColor = System.Drawing.Color.Red;
            this.lblhibas.Location = new System.Drawing.Point(31, 219);
            this.lblhibas.Name = "lblhibas";
            this.lblhibas.Size = new System.Drawing.Size(68, 16);
            this.lblhibas.TabIndex = 14;
            this.lblhibas.Text = "HIBA LABEL";
            this.lblhibas.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chkrememberme
            // 
            this.chkrememberme.AutoSize = true;
            this.chkrememberme.Location = new System.Drawing.Point(60, 199);
            this.chkrememberme.Name = "chkrememberme";
            this.chkrememberme.Size = new System.Drawing.Size(139, 17);
            this.chkrememberme.TabIndex = 16;
            this.chkrememberme.Text = "Maradjak bejelentkezve";
            this.chkrememberme.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 261);
            this.Controls.Add(this.chkrememberme);
            this.Controls.Add(this.lblhibas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txbpass);
            this.Controls.Add(this.txbusername);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 300);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txbpass;
        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblhibas;
        private System.Windows.Forms.CheckBox chkrememberme;
    }
}

