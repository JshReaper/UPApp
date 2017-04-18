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
    }
}
