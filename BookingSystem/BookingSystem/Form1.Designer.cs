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
            this.AdminCalendar = new System.Windows.Forms.MonthCalendar();
            this.Loop = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AdminCalendar
            // 
            this.AdminCalendar.Location = new System.Drawing.Point(51, 35);
            this.AdminCalendar.Name = "AdminCalendar";
            this.AdminCalendar.TabIndex = 0;
            this.AdminCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.AdminCalendar_DateChanged);
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
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AdminCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar AdminCalendar;
        private System.Windows.Forms.Timer Loop;
    }
}

