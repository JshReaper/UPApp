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
        static bool loggedIn = false;
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    
        private void UsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            DatabaseManager.GenerateDataBase();
            if (DatabaseManager.Authenticate(UsernameBox.Text, PasswordBox.Text))
            {
                userID = DatabaseManager.FindID(UsernameBox.Text);
                Login();
            }
        }

        private void Login()
        {
            loggedIn = true;
            UsernameBox.Hide();
            PasswordBox.Hide();
            Login_Button.Hide();
            BrugerLabel.Hide();
            KodeLabel.Hide();

        }

        private void BrugerLabel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
