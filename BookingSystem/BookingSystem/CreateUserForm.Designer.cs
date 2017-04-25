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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.yesCheck = new System.Windows.Forms.CheckBox();
            this.loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fulde navn";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(91, 40);
            this.name_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(190, 20);
            this.name_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brugernavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adgangskode";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(91, 80);
            this.userName_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(190, 20);
            this.userName_txt.TabIndex = 4;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(91, 115);
            this.password_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(190, 20);
            this.password_txt.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(91, 194);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(56, 19);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Gem";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Admin?";
            // 
            // yesCheck
            // 
            this.yesCheck.AutoSize = true;
            this.yesCheck.Location = new System.Drawing.Point(91, 160);
            this.yesCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yesCheck.Name = "yesCheck";
            this.yesCheck.Size = new System.Drawing.Size(44, 17);
            this.yesCheck.TabIndex = 8;
            this.yesCheck.Text = "Yes";
            this.yesCheck.UseVisualStyleBackColor = true;
            // 
            // loop
            // 
            this.loop.Enabled = true;
            this.loop.Interval = 20;
            this.loop.Tick += new System.EventHandler(this.loop_Tick);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 294);
            this.Controls.Add(this.yesCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateUserForm";
            this.Text = "CreateUserForm";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
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
        private System.Windows.Forms.Timer loop;
    }
}