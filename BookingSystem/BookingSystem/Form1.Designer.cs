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
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(94, 38);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(100, 20);
            this.UsernameBox.TabIndex = 0;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(94, 79);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BrugerLabel
            // 
            this.BrugerLabel.AutoSize = true;
            this.BrugerLabel.Location = new System.Drawing.Point(26, 41);
            this.BrugerLabel.Name = "BrugerLabel";
            this.BrugerLabel.Size = new System.Drawing.Size(62, 13);
            this.BrugerLabel.TabIndex = 2;
            this.BrugerLabel.Text = "Brugernavn";
            this.BrugerLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.BrugerLabel_Paint);
            // 
            // KodeLabel
            // 
            this.KodeLabel.AutoSize = true;
            this.KodeLabel.Location = new System.Drawing.Point(26, 82);
            this.KodeLabel.Name = "KodeLabel";
            this.KodeLabel.Size = new System.Drawing.Size(32, 13);
            this.KodeLabel.TabIndex = 3;
            this.KodeLabel.Text = "Kode";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(94, 116);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(75, 23);
            this.Login_Button.TabIndex = 4;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // AdminCalendar
            // 
            this.AdminCalendar.Location = new System.Drawing.Point(51, 35);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.AdminCalendar);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.KodeLabel);
            this.Controls.Add(this.BrugerLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
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
    }
}

