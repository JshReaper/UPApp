namespace BookingSystem
{
    partial class ErrorForm
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(82, 84);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 37);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(35, 13);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "label1";
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.OK_btn);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Label MessageLabel;
    }
}