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
using System.IO;

namespace UserManagement
{
    
    public partial class UserManager : Form
    {
        public static SQLiteConnection dbConn;

        public UserManager()
        {
            InitializeComponent();
            if (!File.Exists(@"UserDatabase.db"))
            {
                SQLiteConnection.CreateFile("UserDatabase.db");
            }
            FillList();

        }

        public void FillList()
        {
            

            dbConn = new SQLiteConnection("data source = UserDatabase.db;Version=3;");
            dbConn.Open();

            string Query = "select * from users;";
            SQLiteCommand addCommand = new SQLiteCommand(Query, dbConn);

            SQLiteDataReader dr;

            try
            {
                dr = addCommand.ExecuteReader();

                while (dr.Read())
                {
                    string names = dr.GetString(dr.GetOrdinal("name")).ToString();
                    userList.Items.Add(names);
                }
            }
            catch
            {

            }
        }

        private void userList_Click(object sender, EventArgs e)
        {

        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConn = new SQLiteConnection("data source = UserDatabase.db;Version=3;");
            dbConn.Open();
            string Query = "select * from users where name = '" + userList.Text + "' ;";
            SQLiteCommand showCommand = new SQLiteCommand(Query, dbConn);

            SQLiteDataReader dr;

            
            try
            {
                dr = showCommand.ExecuteReader();

                while (dr.Read())
                {
                    string nameString = dr.GetString(dr.GetOrdinal("name"));
                    string userNameString = dr.GetString(dr.GetOrdinal("username"));
                    string workDaysString = dr.GetInt32(dr.GetOrdinal("workDays")).ToString();
                    string cleanDaysString = dr.GetInt32(dr.GetOrdinal("cleanDays")).ToString();

                    infoBox.Text = nameString + "\n" + userNameString + "\n" + workDaysString + "\n" + cleanDaysString;
                }
            }
            catch
            {

            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            dbConn = new SQLiteConnection("data source = UserDatabase.db;Version=3;");
            dbConn.Open();
            string Query = "delete * from users where name = '" + userList.SelectedItem + "' ;";
            SQLiteCommand deleteCommand = new SQLiteCommand(Query, dbConn);

            deleteCommand.ExecuteNonQuery();
        }
    }
}
