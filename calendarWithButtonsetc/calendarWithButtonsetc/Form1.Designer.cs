namespace calendarWithButtonsetc
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
            this.TheCalendar = new System.Windows.Forms.MonthCalendar();
            this.Testbel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TheCalendar
            // 
            this.TheCalendar.Location = new System.Drawing.Point(64, 35);
            this.TheCalendar.Name = "TheCalendar";
            this.TheCalendar.TabIndex = 0;
            this.TheCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.TheCalendar_DateSelected);
            // 
            // Testbel
            // 
            this.Testbel.AutoSize = true;
            this.Testbel.Location = new System.Drawing.Point(257, 86);
            this.Testbel.Name = "Testbel";
            this.Testbel.Size = new System.Drawing.Size(35, 13);
            this.Testbel.TabIndex = 1;
            this.Testbel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 229);
            this.Controls.Add(this.Testbel);
            this.Controls.Add(this.TheCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar TheCalendar;
        private System.Windows.Forms.Label Testbel;
    }
}

