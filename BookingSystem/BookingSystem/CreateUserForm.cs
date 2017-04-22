using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BookingSystem
{
    public partial class CreateUserForm : Form
    {
        UserManagerForm userMan = new UserManagerForm();
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConn = new SQLiteConnection("Data Source=Data.db;Version=3;");
            dbConn.Open();
            string chooseAdmin = "0";
            if (yesCheck.Checked)
            {
                chooseAdmin = "1";
            }
            else if (noCheck.Checked)
            {
                chooseAdmin = "0";
            }
            else if (yesCheck.Checked && noCheck.Checked)
            {
                MessageBox.Show("Vælg venligst kun en boks.");
            }

            string user = "Insert into Users values(null, '" + userName_txt.Text + "', '" + password_txt.Text + "', '" + name_txt.Text + "', '" + chooseAdmin + "', 0, 0)";
            SQLiteCommand saveCommand = new SQLiteCommand(user, dbConn);
            SQLiteDataReader dr;

            try
            {
                dr = saveCommand.ExecuteReader();
                MessageBox.Show("Brugeren er nu gemt.");
                while (dr.Read())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbConn.Close();
            dbConn.Dispose();
        }
    }
}
