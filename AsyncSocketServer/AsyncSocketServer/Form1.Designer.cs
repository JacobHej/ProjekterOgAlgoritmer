namespace AsyncSocketServer
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
            this.acceptListenerBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendToAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acceptListenerBtn
            // 
            this.acceptListenerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptListenerBtn.Location = new System.Drawing.Point(12, 346);
            this.acceptListenerBtn.Name = "acceptListenerBtn";
            this.acceptListenerBtn.Size = new System.Drawing.Size(296, 92);
            this.acceptListenerBtn.TabIndex = 0;
            this.acceptListenerBtn.Text = "Accept Incoming Connection";
            this.acceptListenerBtn.UseVisualStyleBackColor = true;
            this.acceptListenerBtn.Click += new System.EventHandler(this.AcceptListenerBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 1;
            // 
            // sendToAllBtn
            // 
            this.sendToAllBtn.Location = new System.Drawing.Point(13, 108);
            this.sendToAllBtn.Name = "sendToAllBtn";
            this.sendToAllBtn.Size = new System.Drawing.Size(295, 38);
            this.sendToAllBtn.TabIndex = 2;
            this.sendToAllBtn.Text = "Send To All";
            this.sendToAllBtn.UseVisualStyleBackColor = true;
            this.sendToAllBtn.Click += new System.EventHandler(this.SendToAllBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.sendToAllBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acceptListenerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button acceptListenerBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendToAllBtn;
    }
}

