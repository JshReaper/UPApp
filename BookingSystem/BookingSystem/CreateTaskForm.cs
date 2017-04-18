using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem
{
    public partial class CreateTaskForm : Form
    {
        public int Day { get; set; }
        public string DayText { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        private string monthText;
        public CreateTaskForm()
        {
            InitializeComponent();
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            switch (Month)
            {
                case 1:
                    monthText = "Januar";
                    break;
                case 2:
                    monthText = "Febuar";
                    break;
                case 3:
                    monthText = "Marts";
                    break;
                case 4:
                    monthText = "April";
                    break;
                case 5:
                    monthText = "Maj";
                    break;
                case 6:
                    monthText = "Juni";
                    break;
                case 7:
                    monthText = "Juli";
                    break;
                case 8:
                    monthText = "August";
                    break;
                case 9:
                    monthText = "September";
                    break;
                case 10:
                    monthText = "Oktober";
                    break;
                case 11:
                    monthText = "November";
                    break;
                case 12:
                    monthText = "December";
                    break;
            }
            MonthAndDay.Text = $@"{Day} {monthText} {Year}";
            DayOfWeek.Text = DayText;
        }

        private void CleaningBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
