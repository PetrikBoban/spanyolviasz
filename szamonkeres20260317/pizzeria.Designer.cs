namespace szamonkeres20260317
{
    partial class pizzeria
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
            this.btnbevitel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbevitel
            // 
            this.btnbevitel.Location = new System.Drawing.Point(220, 223);
            this.btnbevitel.Name = "btnbevitel";
            this.btnbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnbevitel.TabIndex = 0;
            this.btnbevitel.Text = "Adatbevitel";
            this.btnbevitel.UseVisualStyleBackColor = true;
            this.btnbevitel.Click += new System.EventHandler(this.btnbevitel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::szamonkeres20260317.Properties.Resources.pizzeria;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 293);
            this.Controls.Add(this.btnbevitel);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 332);
            this.MinimumSize = new System.Drawing.Size(531, 332);
            this.Name = "pizzeria";
            this.Text = "Pizzéria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbevitel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

