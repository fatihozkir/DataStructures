namespace Soru2
{
    partial class Form1
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
            this.lstDongusel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCircular = new System.Windows.Forms.Button();
            this.lblDonguselOrtalama = new System.Windows.Forms.Label();
            this.lstOncelik = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblOncelik0ToplamSure = new System.Windows.Forms.Label();
            this.lblDonguselToplam = new System.Windows.Forms.Label();
            this.lstOncelik1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.lblOncelik0Ortalama = new System.Windows.Forms.Label();
            this.lblOncelik1ToplamSure = new System.Windows.Forms.Label();
            this.lblOncelik1Ortalama = new System.Windows.Forms.Label();
            this.lstAnaliz = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAnaliz = new System.Windows.Forms.Label();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstDongusel
            // 
            this.lstDongusel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDongusel.Location = new System.Drawing.Point(4, 25);
            this.lstDongusel.Name = "lstDongusel";
            this.lstDongusel.Size = new System.Drawing.Size(243, 393);
            this.lstDongusel.TabIndex = 0;
            this.lstDongusel.UseCompatibleStateImageBehavior = false;
            this.lstDongusel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Müşteri No";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Süre";
            this.columnHeader2.Width = 132;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Döngüsel Kuyruk";
            // 
            // btnCircular
            // 
            this.btnCircular.Location = new System.Drawing.Point(44, 424);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(149, 23);
            this.btnCircular.TabIndex = 2;
            this.btnCircular.Text = "Döngüsel Kuyruğu Başlat";
            this.btnCircular.UseVisualStyleBackColor = true;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // lblDonguselOrtalama
            // 
            this.lblDonguselOrtalama.AutoSize = true;
            this.lblDonguselOrtalama.Location = new System.Drawing.Point(12, 482);
            this.lblDonguselOrtalama.Name = "lblDonguselOrtalama";
            this.lblDonguselOrtalama.Size = new System.Drawing.Size(0, 13);
            this.lblDonguselOrtalama.TabIndex = 1;
            // 
            // lstOncelik
            // 
            this.lstOncelik.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lstOncelik.Location = new System.Drawing.Point(253, 25);
            this.lstOncelik.Name = "lstOncelik";
            this.lstOncelik.Size = new System.Drawing.Size(243, 393);
            this.lstOncelik.TabIndex = 0;
            this.lstOncelik.UseCompatibleStateImageBehavior = false;
            this.lstOncelik.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri No";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süre";
            this.columnHeader4.Width = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öncelik Kuyruk(İşlem Sırası Küçükten Büyüğe)";
            // 
            // lblOncelik0ToplamSure
            // 
            this.lblOncelik0ToplamSure.AutoSize = true;
            this.lblOncelik0ToplamSure.Location = new System.Drawing.Point(299, 457);
            this.lblOncelik0ToplamSure.Name = "lblOncelik0ToplamSure";
            this.lblOncelik0ToplamSure.Size = new System.Drawing.Size(0, 13);
            this.lblOncelik0ToplamSure.TabIndex = 1;
            // 
            // lblDonguselToplam
            // 
            this.lblDonguselToplam.AutoSize = true;
            this.lblDonguselToplam.Location = new System.Drawing.Point(4, 457);
            this.lblDonguselToplam.Name = "lblDonguselToplam";
            this.lblDonguselToplam.Size = new System.Drawing.Size(0, 13);
            this.lblDonguselToplam.TabIndex = 3;
            // 
            // lstOncelik1
            // 
            this.lstOncelik1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lstOncelik1.Location = new System.Drawing.Point(502, 25);
            this.lstOncelik1.Name = "lstOncelik1";
            this.lstOncelik1.Size = new System.Drawing.Size(243, 393);
            this.lstOncelik1.TabIndex = 0;
            this.lstOncelik1.UseCompatibleStateImageBehavior = false;
            this.lstOncelik1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri No";
            this.columnHeader5.Width = 107;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Süre";
            this.columnHeader6.Width = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Öncelik Kuyruk(İşlem Sırası Büyükten Küçüğe)";
            // 
            // lblOncelik0Ortalama
            // 
            this.lblOncelik0Ortalama.AutoSize = true;
            this.lblOncelik0Ortalama.Location = new System.Drawing.Point(299, 482);
            this.lblOncelik0Ortalama.Name = "lblOncelik0Ortalama";
            this.lblOncelik0Ortalama.Size = new System.Drawing.Size(0, 13);
            this.lblOncelik0Ortalama.TabIndex = 1;
            // 
            // lblOncelik1ToplamSure
            // 
            this.lblOncelik1ToplamSure.AutoSize = true;
            this.lblOncelik1ToplamSure.Location = new System.Drawing.Point(556, 457);
            this.lblOncelik1ToplamSure.Name = "lblOncelik1ToplamSure";
            this.lblOncelik1ToplamSure.Size = new System.Drawing.Size(0, 13);
            this.lblOncelik1ToplamSure.TabIndex = 1;
            // 
            // lblOncelik1Ortalama
            // 
            this.lblOncelik1Ortalama.AutoSize = true;
            this.lblOncelik1Ortalama.Location = new System.Drawing.Point(556, 482);
            this.lblOncelik1Ortalama.Name = "lblOncelik1Ortalama";
            this.lblOncelik1Ortalama.Size = new System.Drawing.Size(0, 13);
            this.lblOncelik1Ortalama.TabIndex = 1;
            // 
            // lstAnaliz
            // 
            this.lstAnaliz.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lstAnaliz.Location = new System.Drawing.Point(751, 25);
            this.lstAnaliz.Name = "lstAnaliz";
            this.lstAnaliz.Size = new System.Drawing.Size(611, 393);
            this.lstAnaliz.TabIndex = 0;
            this.lstAnaliz.UseCompatibleStateImageBehavior = false;
            this.lstAnaliz.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Müşteri No";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Döngüsel Kuyruktaki Süre";
            this.columnHeader8.Width = 137;
            // 
            // lblAnaliz
            // 
            this.lblAnaliz.AutoSize = true;
            this.lblAnaliz.Location = new System.Drawing.Point(750, 9);
            this.lblAnaliz.Name = "lblAnaliz";
            this.lblAnaliz.Size = new System.Drawing.Size(0, 13);
            this.lblAnaliz.TabIndex = 1;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Öncelik Kuyruğundaki Süre";
            this.columnHeader9.Width = 142;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "İşlem Süre Analizi";
            this.columnHeader10.Width = 101;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "İşlem Performans Analizi";
            this.columnHeader11.Width = 129;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 506);
            this.Controls.Add(this.lblDonguselToplam);
            this.Controls.Add(this.btnCircular);
            this.Controls.Add(this.lblOncelik1Ortalama);
            this.Controls.Add(this.lblOncelik1ToplamSure);
            this.Controls.Add(this.lblOncelik0Ortalama);
            this.Controls.Add(this.lblOncelik0ToplamSure);
            this.Controls.Add(this.lblDonguselOrtalama);
            this.Controls.Add(this.lblAnaliz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAnaliz);
            this.Controls.Add(this.lstOncelik1);
            this.Controls.Add(this.lstOncelik);
            this.Controls.Add(this.lstDongusel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döngüsel Kuyruk ve Öncelik Kuyruğu Karşılaştırması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstDongusel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.Label lblDonguselOrtalama;
        private System.Windows.Forms.ListView lstOncelik;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOncelik0ToplamSure;
        private System.Windows.Forms.Label lblDonguselToplam;
        private System.Windows.Forms.ListView lstOncelik1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOncelik0Ortalama;
        private System.Windows.Forms.Label lblOncelik1ToplamSure;
        private System.Windows.Forms.Label lblOncelik1Ortalama;
        private System.Windows.Forms.ListView lstAnaliz;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Label lblAnaliz;
    }
}

