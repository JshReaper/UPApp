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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TheCalendar.ShowWeekNumbers = true;
        }

        private void TheCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            TaskAssignment task = new TaskAssignment();
            task.day = Convert.ToInt32(TheCalendar.SelectionStart.Day.ToString());
            task.month = Convert.ToInt32(TheCalendar.SelectionStart.Month.ToString());

            task.Show();
        }
        
    }
}
