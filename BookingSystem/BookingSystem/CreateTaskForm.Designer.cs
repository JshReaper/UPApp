namespace BookingSystem
{
    partial class CreateTaskForm
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
            this.MonthAndDay = new System.Windows.Forms.Label();
            this.DayOfWeek = new System.Windows.Forms.Label();
            this.TidLabel = new System.Windows.Forms.Label();
            this.CleaningBtn = new System.Windows.Forms.Button();
            this.WorkBtn = new System.Windows.Forms.Button();
            this.StartcomboBox = new System.Windows.Forms.ComboBox();
            this.SlutcomboBox = new System.Windows.Forms.ComboBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SlutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthAndDay
            // 
            this.MonthAndDay.AutoSize = true;
            this.MonthAndDay.Location = new System.Drawing.Point(19, 13);
            this.MonthAndDay.Name = "MonthAndDay";
            this.MonthAndDay.Size = new System.Drawing.Size(75, 13);
            this.MonthAndDay.TabIndex = 0;
            this.MonthAndDay.Text = "MonthAndDay";
            this.MonthAndDay.Click += new System.EventHandler(this.MonthAndDay_Click);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(19, 27);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(66, 13);
            this.DayOfWeek.TabIndex = 1;
            this.DayOfWeek.Text = "DayOfWeek";
            // 
            // TidLabel
            // 
            this.TidLabel.AutoSize = true;
            this.TidLabel.Location = new System.Drawing.Point(19, 78);
            this.TidLabel.Name = "TidLabel";
            this.TidLabel.Size = new System.Drawing.Size(22, 13);
            this.TidLabel.TabIndex = 2;
            this.TidLabel.Text = "Tid";
            // 
            // CleaningBtn
            // 
            this.CleaningBtn.Location = new System.Drawing.Point(42, 204);
            this.CleaningBtn.Name = "CleaningBtn";
            this.CleaningBtn.Size = new System.Drawing.Size(75, 23);
            this.CleaningBtn.TabIndex = 3;
            this.CleaningBtn.Text = "Rengøring";
            this.CleaningBtn.UseVisualStyleBackColor = true;
            this.CleaningBtn.Click += new System.EventHandler(this.CleaningBtn_Click);
            // 
            // WorkBtn
            // 
            this.WorkBtn.Location = new System.Drawing.Point(164, 203);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(75, 23);
            this.WorkBtn.TabIndex = 4;
            this.WorkBtn.Text = "Arbejde";
            this.WorkBtn.UseVisualStyleBackColor = true;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // StartcomboBox
            // 
            this.StartcomboBox.FormattingEnabled = true;
            this.StartcomboBox.Items.AddRange(new object[] {
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00"});
            this.StartcomboBox.Location = new System.Drawing.Point(75, 98);
            this.StartcomboBox.Name = "StartcomboBox";
            this.StartcomboBox.Size = new System.Drawing.Size(121, 21);
            this.StartcomboBox.TabIndex = 6;
            // 
            // SlutcomboBox
            // 
            this.SlutcomboBox.FormattingEnabled = true;
            this.SlutcomboBox.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.SlutcomboBox.Location = new System.Drawing.Point(75, 125);
            this.SlutcomboBox.Name = "SlutcomboBox";
            this.SlutcomboBox.Size = new System.Drawing.Size(121, 21);
            this.SlutcomboBox.TabIndex = 7;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(12, 101);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(29, 13);
            this.StartLabel.TabIndex = 8;
            this.StartLabel.Text = "Start";
            // 
            // SlutLabel
            // 
            this.SlutLabel.AutoSize = true;
            this.SlutLabel.Location = new System.Drawing.Point(16, 128);
            this.SlutLabel.Name = "SlutLabel";
            this.SlutLabel.Size = new System.Drawing.Size(25, 13);
            this.SlutLabel.TabIndex = 9;
            this.SlutLabel.Text = "Slut";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SlutLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.SlutcomboBox);
            this.Controls.Add(this.StartcomboBox);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.CleaningBtn);
            this.Controls.Add(this.TidLabel);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.MonthAndDay);
            this.Name = "CreateTaskForm";
            this.Text = "CreateTaskForm";
            this.Load += new System.EventHandler(this.CreateTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MonthAndDay;
        private System.Windows.Forms.Label DayOfWeek;
        private System.Windows.Forms.Label TidLabel;
        private System.Windows.Forms.Button CleaningBtn;
        private System.Windows.Forms.Button WorkBtn;
        private System.Windows.Forms.ComboBox StartcomboBox;
        private System.Windows.Forms.ComboBox SlutcomboBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label SlutLabel;
    }
}