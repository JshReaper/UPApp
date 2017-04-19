namespace UserManagement
{
    partial class UserManager
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
            this.userList = new System.Windows.Forms.ListBox();
            this.listScroll = new System.Windows.Forms.VScrollBar();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 16;
            this.userList.Location = new System.Drawing.Point(12, 29);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(120, 244);
            this.userList.TabIndex = 0;
            this.userList.Click += new System.EventHandler(this.userList_Click);
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // listScroll
            // 
            this.listScroll.Location = new System.Drawing.Point(135, 29);
            this.listScroll.Name = "listScroll";
            this.listScroll.Size = new System.Drawing.Size(18, 244);
            this.listScroll.TabIndex = 1;
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(221, 29);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(274, 244);
            this.infoBox.TabIndex = 2;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(221, 296);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Slet";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 448);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.listScroll);
            this.Controls.Add(this.userList);
            this.Name = "UserManager";
            this.Text = "UserManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.VScrollBar listScroll;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button deleteBtn;
    }
}