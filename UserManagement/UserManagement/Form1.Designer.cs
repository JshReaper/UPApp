namespace UserManagement
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
            this.userManBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userManBtn
            // 
            this.userManBtn.Location = new System.Drawing.Point(39, 255);
            this.userManBtn.Name = "userManBtn";
            this.userManBtn.Size = new System.Drawing.Size(164, 33);
            this.userManBtn.TabIndex = 0;
            this.userManBtn.Text = "Bruger Håndtering";
            this.userManBtn.UseVisualStyleBackColor = true;
            this.userManBtn.Click += new System.EventHandler(this.userManBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 314);
            this.Controls.Add(this.userManBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userManBtn;
    }
}

