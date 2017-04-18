using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendarWithButtonsetc
{
    public partial class TaskAssignment : Form
    {
        public int month;
        string monthText;
        public int day;
        public TaskAssignment()
        {
            InitializeComponent();
        }

        private void TaskAssignment_Load(object sender, EventArgs e)
        {
            switch (month)
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
                default:
                    break;
            }
            string test = "day: " + day.ToString() + "\nMonth: " + monthText; 
            DayAndMonth.Text = test;
        }
    }
}
