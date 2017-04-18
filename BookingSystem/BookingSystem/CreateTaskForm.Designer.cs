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
            this.SuspendLayout();
            // 
            // MonthAndDay
            // 
            this.MonthAndDay.AutoSize = true;
            this.MonthAndDay.Location = new System.Drawing.Point(13, 13);
            this.MonthAndDay.Name = "MonthAndDay";
            this.MonthAndDay.Size = new System.Drawing.Size(75, 13);
            this.MonthAndDay.TabIndex = 0;
            this.MonthAndDay.Text = "MonthAndDay";
            // 
            // DayOfWeek
            // 
            this.DayOfWeek.AutoSize = true;
            this.DayOfWeek.Location = new System.Drawing.Point(16, 30);
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
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}