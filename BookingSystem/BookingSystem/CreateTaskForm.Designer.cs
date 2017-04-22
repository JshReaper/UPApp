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
            this.Tidspunkt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MonthAndDay
            // 
            this.MonthAndDay.AutoSize = true;
            this.MonthAndDay.Location = new System.Drawing.Point(25, 16);
            this.MonthAndDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthAndDay.Name = "MonthAndDay";
            this.MonthAndDay.Size = new System.Drawing.Size(97, 17);
            this.MonthAndDay.TabIndex = 0;
            this.MonthAndDay.Text = "MonthAndDay";
            this.MonthAndDay.Click += new System.EventHandler(this.MonthAndDay_Click);
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(25, 33);
            this.DayOfWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DayOfWeek.Name = "DayOfWeek";
            this.DayOfWeek.Size = new System.Drawing.Size(84, 17);
            this.DayOfWeek.TabIndex = 1;
            this.DayOfWeek.Text = "DayOfWeek";
            // 
            // TidLabel
            // 
            this.TidLabel.AutoSize = true;
            this.TidLabel.Location = new System.Drawing.Point(25, 96);
            this.TidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TidLabel.Name = "TidLabel";
            this.TidLabel.Size = new System.Drawing.Size(28, 17);
            this.TidLabel.TabIndex = 2;
            this.TidLabel.Text = "Tid";
            // 
            // CleaningBtn
            // 
            this.CleaningBtn.Location = new System.Drawing.Point(56, 251);
            this.CleaningBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CleaningBtn.Name = "CleaningBtn";
            this.CleaningBtn.Size = new System.Drawing.Size(100, 28);
            this.CleaningBtn.TabIndex = 3;
            this.CleaningBtn.Text = "Rengøring";
            this.CleaningBtn.UseVisualStyleBackColor = true;
            this.CleaningBtn.Click += new System.EventHandler(this.CleaningBtn_Click);
            // 
            // WorkBtn
            // 
            this.WorkBtn.Location = new System.Drawing.Point(219, 250);
            this.WorkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(100, 28);
            this.WorkBtn.TabIndex = 4;
            this.WorkBtn.Text = "Arbejde";
            this.WorkBtn.UseVisualStyleBackColor = true;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // Tidspunkt
            // 
            this.Tidspunkt.Location = new System.Drawing.Point(28, 128);
            this.Tidspunkt.MaxLength = 11;
            this.Tidspunkt.Name = "Tidspunkt";
            this.Tidspunkt.Size = new System.Drawing.Size(291, 22);
            this.Tidspunkt.TabIndex = 5;
            this.Tidspunkt.TextChanged += new System.EventHandler(this.Tidspunkt_TextChanged);
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.Tidspunkt);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.CleaningBtn);
            this.Controls.Add(this.TidLabel);
            this.Controls.Add(this.DayOfWeek);
            this.Controls.Add(this.MonthAndDay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox Tidspunkt;
    }
}