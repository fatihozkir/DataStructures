namespace ArrayTypedQueue
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
            this.btnSimpleQueueTest = new System.Windows.Forms.Button();
            this.btnCircular = new System.Windows.Forms.Button();
            this.btnPriorityQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleQueueTest
            // 
            this.btnSimpleQueueTest.Location = new System.Drawing.Point(49, 32);
            this.btnSimpleQueueTest.Name = "btnSimpleQueueTest";
            this.btnSimpleQueueTest.Size = new System.Drawing.Size(174, 23);
            this.btnSimpleQueueTest.TabIndex = 0;
            this.btnSimpleQueueTest.Text = "ArrayTypedSimpleQueue Test";
            this.btnSimpleQueueTest.UseVisualStyleBackColor = true;
            this.btnSimpleQueueTest.Click += new System.EventHandler(this.btnSimpleQueueTest_Click);
            // 
            // btnCircular
            // 
            this.btnCircular.Location = new System.Drawing.Point(49, 61);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(174, 23);
            this.btnCircular.TabIndex = 1;
            this.btnCircular.Text = "ArrayTypedCircularQueue Test";
            this.btnCircular.UseVisualStyleBackColor = true;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // btnPriorityQueue
            // 
            this.btnPriorityQueue.Location = new System.Drawing.Point(49, 90);
            this.btnPriorityQueue.Name = "btnPriorityQueue";
            this.btnPriorityQueue.Size = new System.Drawing.Size(174, 23);
            this.btnPriorityQueue.TabIndex = 2;
            this.btnPriorityQueue.Text = "ArrayTypedPriorityQueue Test";
            this.btnPriorityQueue.UseVisualStyleBackColor = true;
            this.btnPriorityQueue.Click += new System.EventHandler(this.btnPriorityQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPriorityQueue);
            this.Controls.Add(this.btnCircular);
            this.Controls.Add(this.btnSimpleQueueTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleQueueTest;
        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.Button btnPriorityQueue;
    }
}

