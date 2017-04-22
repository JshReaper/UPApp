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
        bool stringIsGood = false;
        string startString= "empty";
        string[] splitString;
        string endStringOne;
        string endStringTwo;
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
            //set in if statement
            ErrorForm error = new ErrorForm("Der opstod en fejl.");
            //error = new ErrorForm("Opgave allerede tildelt til den valgte dato");
            stringIsGood = testString(startString);
            if (stringIsGood == false)
            {
                error = new ErrorForm("Opgavens tidspunkt er ikke korrekt indtastet");
                error.ShowDialog();
                error = new ErrorForm("Der opstod en fejl.");
            }
            if (stringIsGood == true)
            {
                splitString = startString.Split('-');
                endStringOne = splitString[0];
                endStringTwo = splitString[1];
                DatabaseManager.CreateTask(Day, Month, Year, true, endStringOne, endStringTwo);
                startString = "empty";
                splitString = null;
                endStringOne = "empty";
                endStringTwo = "empty";
                Close();
            }
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            //set in if statement
            ErrorForm error = new ErrorForm("Der opstod en fejl.");
            stringIsGood = testString(startString);
            if (stringIsGood == false)
            {
                error = new ErrorForm("Opgavens tidspunkt er ikke korrekt indtastet");
                error.ShowDialog();
                error = new ErrorForm("Der opstod en fejl.");
            }
            if (stringIsGood == true)
            {
                splitString = startString.Split('-');
                endStringOne = splitString[0];
                endStringTwo = splitString[1];
                DatabaseManager.CreateTask(Day, Month, Year, false, endStringOne, endStringTwo);
                startString = "empty";
                splitString = null;
                endStringOne = "empty";
                endStringTwo = "empty";
                Close();
            }
        }
        public static bool testString(string s)
        {
            int dashes = 0;
            int colons = 0;
            //Count the dashes and colons in the string.
            foreach (char c in s)
            {
                if (c == '-')
                {
                    dashes++;
                }
                if (c == ':')
                {
                    colons++;
                }
            }
            //Confirms the string only contains numbers, colons and dashes.
            foreach (char c in s)
            {
                if (!Char.IsDigit(c) && c != ':' && c != '-')
                {
                    return false;
                }
            }
            //If the string contains nothing, return false.
            if (s == "")
            {
                return false;
            }
            //If the string does not contain a dash, return false.
            if (dashes != 1)
            {
                return false;
            }
            //If the string contains colons, confirm there's exactly 2 of them.
            if (colons > 0)
            {
                if (colons != 2)
                {
                    return false;
                }
            }
            //Check if the user has made a common typo.
            if (s.Contains("::"))
            {
                return false;
            }
            return true;
        }

        /*
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        */

        private void Tidspunkt_TextChanged(object sender, EventArgs e)
        {
            startString = this.Tidspunkt.Text;
        }

        private void MonthAndDay_Click(object sender, EventArgs e)
        {

        }
    }
}
