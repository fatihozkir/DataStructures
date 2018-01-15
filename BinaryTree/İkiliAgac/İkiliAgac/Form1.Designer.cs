namespace İkiliAgac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBT = new System.Windows.Forms.Button();
            this.btnİkiliAgacOlusturGezinmeİcin = new System.Windows.Forms.Button();
            this.cmbTraverseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDugumSayisi = new System.Windows.Forms.Button();
            this.btnYaprakSayisi = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBT
            // 
            this.btnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBT.Location = new System.Drawing.Point(12, 12);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(377, 30);
            this.btnBT.TabIndex = 2;
            this.btnBT.Text = "Örnek 1. Sadece Düğüm Sınıfı ile İkili Ağaç Oluştur";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click_1);
            // 
            // btnİkiliAgacOlusturGezinmeİcin
            // 
            this.btnİkiliAgacOlusturGezinmeİcin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİkiliAgacOlusturGezinmeİcin.Location = new System.Drawing.Point(12, 70);
            this.btnİkiliAgacOlusturGezinmeİcin.Name = "btnİkiliAgacOlusturGezinmeİcin";
            this.btnİkiliAgacOlusturGezinmeİcin.Size = new System.Drawing.Size(377, 30);
            this.btnİkiliAgacOlusturGezinmeİcin.TabIndex = 4;
            this.btnİkiliAgacOlusturGezinmeİcin.Text = "Örnek 2. İkili Ağaç Oluştur Gezinme İçin...";
            this.btnİkiliAgacOlusturGezinmeİcin.UseVisualStyleBackColor = true;
            this.btnİkiliAgacOlusturGezinmeİcin.Click += new System.EventHandler(this.btnİkiliAgacOlusturGezinmeİcin_Click);
            // 
            // cmbTraverseType
            // 
            this.cmbTraverseType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTraverseType.FormattingEnabled = true;
            this.cmbTraverseType.Items.AddRange(new object[] {
            "Preorder",
            "Inorder",
            "Postorder"});
            this.cmbTraverseType.Location = new System.Drawing.Point(131, 128);
            this.cmbTraverseType.Name = "cmbTraverseType";
            this.cmbTraverseType.Size = new System.Drawing.Size(91, 21);
            this.cmbTraverseType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gezinme Şekli:";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrder.Location = new System.Drawing.Point(278, 121);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(111, 30);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Dolaş";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(12, 170);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(377, 23);
            this.txtSonuc.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(395, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 321);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Örnek 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 273);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Örnek2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 273);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnDugumSayisi
            // 
            this.btnDugumSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDugumSayisi.Location = new System.Drawing.Point(12, 216);
            this.btnDugumSayisi.Name = "btnDugumSayisi";
            this.btnDugumSayisi.Size = new System.Drawing.Size(184, 30);
            this.btnDugumSayisi.TabIndex = 10;
            this.btnDugumSayisi.Text = "2.1.Düğüm Sayısı";
            this.btnDugumSayisi.UseVisualStyleBackColor = true;
            this.btnDugumSayisi.Click += new System.EventHandler(this.btnDugumSayisi_Click);
            // 
            // btnYaprakSayisi
            // 
            this.btnYaprakSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaprakSayisi.Location = new System.Drawing.Point(221, 216);
            this.btnYaprakSayisi.Name = "btnYaprakSayisi";
            this.btnYaprakSayisi.Size = new System.Drawing.Size(168, 30);
            this.btnYaprakSayisi.TabIndex = 11;
            this.btnYaprakSayisi.Text = "2.2.Yaprak Sayısı";
            this.btnYaprakSayisi.UseVisualStyleBackColor = true;
            this.btnYaprakSayisi.Click += new System.EventHandler(this.btnYaprakSayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 351);
            this.Controls.Add(this.btnYaprakSayisi);
            this.Controls.Add(this.btnDugumSayisi);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTraverseType);
            this.Controls.Add(this.btnİkiliAgacOlusturGezinmeİcin);
            this.Controls.Add(this.btnBT);
            this.Name = "Form1";
            this.Text = "CBU HFTTF Binary Tree";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Button btnİkiliAgacOlusturGezinmeİcin;
        private System.Windows.Forms.ComboBox cmbTraverseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDugumSayisi;
        private System.Windows.Forms.Button btnYaprakSayisi;

    }
}

