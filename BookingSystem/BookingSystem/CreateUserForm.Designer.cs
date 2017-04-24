namespace BookingSystem
{
    partial class CreateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yesCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fulde navn";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(121, 49);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(252, 22);
            this.name_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brugernavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adgangskode";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(121, 98);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(252, 22);
            this.userName_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(121, 142);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(252, 22);
            this.password_txt.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(121, 239);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Gem";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Admin?";
            // 
            // yesCheck
            // 
            this.yesCheck.AutoSize = true;
            this.yesCheck.Location = new System.Drawing.Point(121, 197);
            this.yesCheck.Name = "yesCheck";
            this.yesCheck.Size = new System.Drawing.Size(54, 21);
            this.yesCheck.TabIndex = 8;
            this.yesCheck.Text = "Yes";
            this.yesCheck.UseVisualStyleBackColor = true;
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 362);
            this.Controls.Add(this.yesCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox yesCheck;
    }
}