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
        static int userID = 0;
        bool loggedIn;
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
            if (!isAdmin && loggedIn)
            {
                //user
            }
            else if (isAdmin && loggedIn)
            {
                //admin
                AdminCalendar.Show();
                userManBtn.Show();
                
            }
            if (loggedIn)
            {
                //all
                Logout.Show();
                
            }
            else
            {
                //not logged in
                ////
                //TOHIDE
                ////
                AdminCalendar.Hide();
                userManBtn.Hide();
                Logout.Hide();
                ////
                //TOSHOW
                ////
                UsernameBox.Show();
                PasswordBox.Show();
                Login_Button.Show();
                BrugerLabel.Show();
                KodeLabel.Show();
                cridentials.Show();
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseManager.GenerateDataBase();

            foreach (var date in GetDates(AdminCalendar.SelectionStart.Year, AdminCalendar.SelectionStart.Month))
            {
                AdminCalendar.SetSelectionRange(date,date);
                if (DatabaseManager.TaskExist(date.Day, date.Month, date.Year))
                {

                }
            }
            isAdmin = true;
            AdminCalendar.ShowWeekNumbers = true;
        }
        List<DateTime> GetDates(int year, int month)
        {
            var dates = new List<DateTime>();

            // Loop from the first day of the month until we hit the next month, moving forward a day at a time
            for (var date = new DateTime(year, month, 1); date.Month == month; date = date.AddDays(1))
            {
                dates.Add(date);
            }

            return dates;
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
            if (DatabaseManager.TaskExist(taskForm.Day, taskForm.Month, taskForm.Year))
            {
                ErrorForm error = new ErrorForm("opgave allerede oprettet på valgte dato");
                error.ShowDialog();
            }
            else
            {
                taskForm.ShowDialog();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (DatabaseManager.Authenticate(UsernameBox.Text, PasswordBox.Text))
            {
                userID = DatabaseManager.FindID(UsernameBox.Text);
                Login();
            }
            else if (DatabaseManager.Authenticate(UsernameBox.Text, PasswordBox.Text) == false)
            {
                cridentials.Text = "Brugernavn og Kode passer ikke";
                cridentials.ForeColor = Color.Red;
            }
        }

        private void Login()
        {
            loggedIn = true;
            UsernameBox.Hide();
            UsernameBox.Text = "";
            PasswordBox.Hide();
            PasswordBox.Text = "";
            Login_Button.Hide();
            BrugerLabel.Hide();
            KodeLabel.Hide();
            cridentials.Hide();
        }

        private void BrugerLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userManBtn_Click(object sender, EventArgs e)
        {
            UserManagerForm userMan = new UserManagerForm();
            UserManagerForm.FillList();
            userMan.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loggedIn = false;

        }
    }
}
