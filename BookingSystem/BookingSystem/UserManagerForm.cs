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
using System.Diagnostics;

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
            SQLiteConnection dbConn = new SQLiteConnection("Data Source=Data.db;Version=3;");
            dbConn.Open();


            string deleteUser = "delete from Users where Name= '" + userList.SelectedItem + "' ;";
            SQLiteCommand deleteCommand = new SQLiteCommand(deleteUser, dbConn);
            SQLiteDataReader dr;

            try
            {
                dr = deleteCommand.ExecuteReader();
                MessageBox.Show("Brugeren er nu slettet.");
                while (dr.Read())
                {
                    userList.Items.Remove(userList.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbConn.Close();

        }

        private void newUser_Click(object sender, EventArgs e)
        {
            CreateUserForm userForm = new CreateUserForm();


            userForm.Show();
        }
    }
}
