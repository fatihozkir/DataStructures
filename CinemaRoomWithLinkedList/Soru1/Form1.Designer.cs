namespace Soru1
{
    partial class FrmSalon
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
            this.lblBosKoltuk = new System.Windows.Forms.Label();
            this.lblDoluKoltuk = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Koltuklar = new System.Windows.Forms.Panel();
            this.lblDoluSayi = new System.Windows.Forms.Label();
            this.lblBosSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBosKoltuk
            // 
            this.lblBosKoltuk.AutoSize = true;
            this.lblBosKoltuk.Location = new System.Drawing.Point(702, 34);
            this.lblBosKoltuk.Name = "lblBosKoltuk";
            this.lblBosKoltuk.Size = new System.Drawing.Size(91, 13);
            this.lblBosKoltuk.TabIndex = 3;
            this.lblBosKoltuk.Text = "Boş Koltuk Sayisi:";
            // 
            // lblDoluKoltuk
            // 
            this.lblDoluKoltuk.AutoSize = true;
            this.lblDoluKoltuk.Location = new System.Drawing.Point(702, 65);
            this.lblDoluKoltuk.Name = "lblDoluKoltuk";
            this.lblDoluKoltuk.Size = new System.Drawing.Size(95, 13);
            this.lblDoluKoltuk.TabIndex = 2;
            this.lblDoluKoltuk.Text = "Dolu Koltuk Sayisi:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox2.Location = new System.Drawing.Point(667, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 26);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Location = new System.Drawing.Point(667, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(45, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(599, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Perde";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Koltuklar
            // 
            this.Koltuklar.Location = new System.Drawing.Point(18, 112);
            this.Koltuklar.Name = "Koltuklar";
            this.Koltuklar.Size = new System.Drawing.Size(839, 336);
            this.Koltuklar.TabIndex = 1;
            // 
            // lblDoluSayi
            // 
            this.lblDoluSayi.AutoSize = true;
            this.lblDoluSayi.Location = new System.Drawing.Point(803, 65);
            this.lblDoluSayi.Name = "lblDoluSayi";
            this.lblDoluSayi.Size = new System.Drawing.Size(13, 13);
            this.lblDoluSayi.TabIndex = 4;
            this.lblDoluSayi.Tag = "Dolu";
            this.lblDoluSayi.Text = "0";
            // 
            // lblBosSayi
            // 
            this.lblBosSayi.AutoSize = true;
            this.lblBosSayi.Location = new System.Drawing.Point(803, 34);
            this.lblBosSayi.Name = "lblBosSayi";
            this.lblBosSayi.Size = new System.Drawing.Size(0, 13);
            this.lblBosSayi.TabIndex = 4;
            this.lblBosSayi.Tag = "Bos";
            // 
            // FrmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 460);
            this.Controls.Add(this.lblBosSayi);
            this.Controls.Add(this.lblDoluSayi);
            this.Controls.Add(this.lblBosKoltuk);
            this.Controls.Add(this.lblDoluKoltuk);
            this.Controls.Add(this.Koltuklar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatih Özkır Salonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBosKoltuk;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel Koltuklar;
        private System.Windows.Forms.Label lblDoluKoltuk;
        private System.Windows.Forms.Label lblDoluSayi;
        private System.Windows.Forms.Label lblBosSayi;
    }
}

