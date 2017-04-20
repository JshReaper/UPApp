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
    public partial class UserManagerForm : Form
    {
        public UserManagerForm()
        {
            InitializeComponent();
            FillList();
        }

        public void FillList()
        {
            SQLiteConnection dbConn = new SQLiteConnection("data source = Data.db;Version=3;");
            dbConn.Open();

            string Query = "select * from Users where IsAdmin = '" + 0 + "' ;";
            SQLiteCommand addCommand = new SQLiteCommand(Query, dbConn);

            SQLiteDataReader dr;

            try
            {
                dr = addCommand.ExecuteReader();

                while (dr.Read())
                {
                    string names = dr.GetString(dr.GetOrdinal("Name")).ToString();
                    userList.Items.Add(names);
                }
            }
            catch
            {

            }
            dbConn.Close();
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteConnection dbConn = new SQLiteConnection("data source = Data.db;Version=3;");
            dbConn.Open();
            string Query = "select * from Users where name = '" + userList.Text + "' ;";
            SQLiteCommand showCommand = new SQLiteCommand(Query, dbConn);

            SQLiteDataReader dr;


            try
            {
                dr = showCommand.ExecuteReader();

                while (dr.Read())
                {
                    string nameString = dr.GetString(dr.GetOrdinal("Name"));
                    string userNameString = dr.GetString(dr.GetOrdinal("Username"));

                    infoBox.Text = "Name: " + nameString + "\nUser name: " + userNameString;
                }
            }
            catch
            {

            }
            dbConn.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SQLiteConnection dbConn = new SQLiteConnection("data source = UserDatabase.db;Version=3;");
            dbConn.Open();
            string Query = "delete * from Users where name = '" + userList.SelectedItem + "' ;";
            SQLiteCommand deleteCommand = new SQLiteCommand(Query, dbConn);

            deleteCommand.ExecuteNonQuery();

            dbConn.Close();
        }
    }
}
