namespace BookingSystem
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
            this.components = new System.ComponentModel.Container();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.BrugerLabel = new System.Windows.Forms.Label();
            this.KodeLabel = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.AdminCalendar = new System.Windows.Forms.MonthCalendar();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.userManBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(125, 47);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(132, 22);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(125, 97);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(132, 22);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BrugerLabel
            // 
            this.BrugerLabel.AutoSize = true;
            this.BrugerLabel.Location = new System.Drawing.Point(35, 50);
            this.BrugerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrugerLabel.Name = "BrugerLabel";
            this.BrugerLabel.Size = new System.Drawing.Size(82, 17);
            this.BrugerLabel.TabIndex = 2;
            this.BrugerLabel.Text = "Brugernavn";
            this.BrugerLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.BrugerLabel_Paint);
            // 
            // KodeLabel
            // 
            this.KodeLabel.AutoSize = true;
            this.KodeLabel.Location = new System.Drawing.Point(35, 101);
            this.KodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KodeLabel.Name = "KodeLabel";
            this.KodeLabel.Size = new System.Drawing.Size(41, 17);
            this.KodeLabel.TabIndex = 3;
            this.KodeLabel.Text = "Kode";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(125, 143);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(100, 28);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // AdminCalendar
            // 
            this.AdminCalendar.Location = new System.Drawing.Point(68, 43);
            this.AdminCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.AdminCalendar.Name = "AdminCalendar";
            this.AdminCalendar.TabIndex = 0;
            this.AdminCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AdminCalendar_DateChanged);
            this.AdminCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.AdminCalendar_DateSelected);
            // 
            // Loop
            // 
            this.Loop.Enabled = true;
            this.Loop.Interval = 40;
            this.Loop.Tick += new System.EventHandler(this.Loop_Tick);
            // 
            // userManBtn
            // 
            this.userManBtn.Location = new System.Drawing.Point(68, 265);
            this.userManBtn.Name = "userManBtn";
            this.userManBtn.Size = new System.Drawing.Size(199, 37);
            this.userManBtn.TabIndex = 5;
            this.userManBtn.Text = "Brugerhåndtering";
            this.userManBtn.UseVisualStyleBackColor = true;
            this.userManBtn.Click += new System.EventHandler(this.userManBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 314);
            this.Controls.Add(this.userManBtn);
            this.Controls.Add(this.AdminCalendar);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.KodeLabel);
            this.Controls.Add(this.BrugerLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar AdminCalendar;
        private System.Windows.Forms.Timer Loop;

        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label BrugerLabel;
        private System.Windows.Forms.Label KodeLabel;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button userManBtn;
    }
}

