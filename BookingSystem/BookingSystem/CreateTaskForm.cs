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
        private string _monthText;
        public CreateTaskForm()
        {
            InitializeComponent();
        }

        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            switch (Month)
            {
                case 1:
                    _monthText = "Januar";
                    break;
                case 2:
                    _monthText = "Febuar";
                    break;
                case 3:
                    _monthText = "Marts";
                    break;
                case 4:
                    _monthText = "April";
                    break;
                case 5:
                    _monthText = "Maj";
                    break;
                case 6:
                    _monthText = "Juni";
                    break;
                case 7:
                    _monthText = "Juli";
                    break;
                case 8:
                    _monthText = "August";
                    break;
                case 9:
                    _monthText = "September";
                    break;
                case 10:
                    _monthText = "Oktober";
                    break;
                case 11:
                    _monthText = "November";
                    break;
                case 12:
                    _monthText = "December";
                    break;
            }
            MonthAndDay.Text = $@"{Day} {_monthText} {Year}";
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
