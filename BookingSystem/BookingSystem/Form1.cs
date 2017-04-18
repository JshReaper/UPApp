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
    public partial class Form1 : Form
    {
        bool isAdmin;
        public Form1()
        {
            InitializeComponent();
        }

        private void AdminCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Loop_Tick(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                AdminCalendar.Show();
            }
            else
            {
                AdminCalendar.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isAdmin = true;
            AdminCalendar.ShowWeekNumbers = true;
        }

        private void AdminCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var taskForm = new CreateTaskForm
            {
                Day = AdminCalendar.SelectionStart.Day,
                Month = AdminCalendar.SelectionStart.Month,
                Year = AdminCalendar.SelectionStart.Year
            };
            switch (AdminCalendar.SelectionStart.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    taskForm.DayText = "Søndag";
                    break;
                case DayOfWeek.Monday:
                    taskForm.DayText = "Mandag";
                    break;
                case DayOfWeek.Tuesday:
                    taskForm.DayText = "Tirsdag";
                    break;
                case DayOfWeek.Wednesday:
                    taskForm.DayText = "Onsdag";
                    break;
                case DayOfWeek.Thursday:
                    taskForm.DayText = "Torsdag";
                    break;
                case DayOfWeek.Friday:
                    taskForm.DayText = "Fredag";
                    break;
                case DayOfWeek.Saturday:
                    taskForm.DayText = "Lørdag";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            taskForm.Show();
        }
    }
}
