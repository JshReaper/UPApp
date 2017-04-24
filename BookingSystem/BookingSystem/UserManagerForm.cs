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
        static ListBox box = new ListBox();
        static bool listChanged;

        public static void FillList()
        {
            box.Items.Clear();
            listChanged = true;
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
                    box.Items.Add(names);
                }
            }
            catch
            {

            }
            dbConn.Close();
            dbConn.Dispose();
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user = userList.Text;
            DatabaseManager.SelectUser(ref user,ref id,ref infoBox);
            //SQLiteConnection dbConn = new SQLiteConnection("data source = Data.db;Version=3;");
            //dbConn.Open();
            //SQLiteCommand showCommand = new SQLiteCommand(Query, dbConn);

            //SQLiteDataReader dr;


            //try
            //{
            //    dr = showCommand.ExecuteReader();

            //    while (dr.Read())
            //    {
            //        string nameString = dr.GetString(dr.GetOrdinal("Name"));
            //        string userNameString = dr.GetString(dr.GetOrdinal("Username"));
            //        id = dr.GetInt32(dr.GetOrdinal("ID"));
            //        infoBox.Text = "Name: " + nameString + "\nUser name: " + userNameString;
            //    }
            //}
            //catch
            //{
                
            //}
            //dbConn.Close();
        }

        private int id;
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            try
            {
                DatabaseManager.DeleteUser(id, ref infoBox);
                
                userList.Items.Remove(userList.SelectedItem);
            }

            //SQLiteConnection dbConn = new SQLiteConnection("Data Source=Data.db;Version=3;");
            //dbConn.Open();


            //SQLiteCommand deleteCommand = new SQLiteCommand(deleteUser, dbConn);
            //SQLiteDataReader dr;

            //try
            //{
            //    dr = deleteCommand.ExecuteReader();
            //    MessageBox.Show("Brugeren er nu slettet.");
            //    while (dr.Read())
            //    {
            //        userList.Items.Remove(userList.SelectedItem);
            //    }
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dbConn.Close();

        }

        private void newUser_Click(object sender, EventArgs e)
        {
            CreateUserForm userForm = new CreateUserForm();


            userForm.Show();
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (listChanged)
            {
                userList.Items.Clear();
                for (int i = 0; i < box.Items.Count; i++)
                {
                    userList.Items.Add(box.Items[i]);
                }
                listChanged = false;
            }
        }
    }
}
