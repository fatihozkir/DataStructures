namespace Srch
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
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.txtArananSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOnce = new System.Windows.Forms.TextBox();
            this.btnbinarySearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(166, 81);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(118, 23);
            this.btnLinearSearch.TabIndex = 0;
            this.btnLinearSearch.Text = "Linear Search";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // txtArananSayi
            // 
            this.txtArananSayi.Location = new System.Drawing.Point(166, 55);
            this.txtArananSayi.Name = "txtArananSayi";
            this.txtArananSayi.Size = new System.Drawing.Size(118, 20);
            this.txtArananSayi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aranan Sayı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOnce);
            this.groupBox1.Location = new System.Drawing.Point(35, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oluşan Dizi";
            // 
            // txtOnce
            // 
            this.txtOnce.Location = new System.Drawing.Point(6, 19);
            this.txtOnce.Multiline = true;
            this.txtOnce.Name = "txtOnce";
            this.txtOnce.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOnce.Size = new System.Drawing.Size(330, 220);
            this.txtOnce.TabIndex = 0;
            this.txtOnce.TextChanged += new System.EventHandler(this.txtOnce_TextChanged);
            // 
            // btnbinarySearch
            // 
            this.btnbinarySearch.Location = new System.Drawing.Point(166, 110);
            this.btnbinarySearch.Name = "btnbinarySearch";
            this.btnbinarySearch.Size = new System.Drawing.Size(118, 23);
            this.btnbinarySearch.TabIndex = 5;
            this.btnbinarySearch.Text = "Binary Search";
            this.btnbinarySearch.UseVisualStyleBackColor = true;
            this.btnbinarySearch.Click += new System.EventHandler(this.btnbinarySearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 413);
            this.Controls.Add(this.btnbinarySearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArananSayi);
            this.Controls.Add(this.btnLinearSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLinearSearch;
        private System.Windows.Forms.TextBox txtArananSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOnce;
        private System.Windows.Forms.Button btnbinarySearch;
    }
}

