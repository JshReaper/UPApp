using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace BookingSystem
{
    public static class DatabaseManager
    {

        public static void GenerateDataBase()
        {

            if (!File.Exists("Data.db"))
            {
                SQLiteConnection.CreateFile("Data.db");
                SQLiteConnection dbConnOnCreate = new SQLiteConnection("Data Source=Data.db;Version=3;");
                dbConnOnCreate.Open();


                //initial logic
                string userTable = "create table Users (id integer primary key, Username string, Password string, Name string, IsAdmin bool, WorkingDays integer, CleaningDays integer)";
                SQLiteCommand commandOnCreate = new SQLiteCommand(userTable, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();
                string user = "Insert into Users values(null, \"admin\", \"admin\", \"ADMINISTRATOR\", 1, 0, 0)";
                commandOnCreate = new SQLiteCommand(user, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();
                user = "Insert into Users values(null, \"poul\", \"poul\", \"Poul Erik Mågensen\", 0, 0, 0)";
                commandOnCreate = new SQLiteCommand(user, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();
                string workTable = "create table Tasks (id integer primary key, day integer, month integer, year integer, assignee integer, type bool, start string, end string )";
                commandOnCreate = new SQLiteCommand(workTable, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();


                //end logic
                dbConnOnCreate.Close();
                dbConnOnCreate.Dispose();
                commandOnCreate.Dispose();

            }
        }

        /// <summary>
        /// This method asks the database if there is a user by the inserted name in the database, if there is procede to check if 
        /// the password is correct and then if it is, authenticate will return true and user will be allowed access.
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static bool Authenticate(string Username, string Password)
        {
            string retriver = string.Format("Select * from Users where Username = '{0}'", Username);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(retriver, dbCon);
            dbCon.Open();
            //logic
            SQLiteDataReader dr;
            dr = dbCom.ExecuteReader();

            dr.Read();
            if (dr.HasRows)
            {
                if (dr.GetString(1) != Username)
                {
                    dbCon.Close();

                    dbCon.Dispose();

                    dr.Dispose();
                    dbCom.Dispose();
                    Debug.WriteLine("User was not found");
                    return false;
                }
                if (dr.GetString(1) == Username && dr.GetString(2) == Password)
                {
                    dbCon.Close();
                    dbCon.Dispose();

                    dr.Dispose();
                    dbCom.Dispose();
                    Debug.WriteLine("User is now loggedin");
                    return true;
                }
            }
            //end logic
            dbCon.Close();

            dbCon.Dispose();
            dr.Dispose();
            dbCom.Dispose();
            Debug.WriteLine("Logic has failed");
            return false;
        }

        /// <summary>
        /// Will find the id of a user by username, this command can only be run after authenticate has run
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        public static int FindID(string Username)
        {
            string retriver = string.Format("Select * from Users where Username = '{0}'", Username);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(retriver, dbCon);
            dbCon.Open();
            //logic
            SQLiteDataReader dr = dbCom.ExecuteReader();
            dr.Read();


            //end logic
            int toReturn = dr.GetInt32(0);
            dbCon.Close();
            dbCon.Dispose();
            dr.Dispose();
            dbCom.Dispose();
            return toReturn;
        }

        /// <summary>
        /// Creates a task in the database with the given information
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="cleaning"></param>
        public static void CreateTask(int day, int month, int year, bool cleaning, string start, string end)
        {
            int clean;
            if (cleaning)
            {
                clean = 1;
            }
            else
            {
                clean = 0;
            }

            string add = string.Format("insert into Tasks values(null,{0},{1},{2},0,{3},\"{4}\",\"{5}\")", day, month, year, clean, start, end);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(add, dbCon);
            dbCon.Open();
            Debug.WriteLine("Database open");
            //logic
            try
            {
                dbCom.ExecuteNonQuery();
                dbCom.Dispose();
            }
            catch
            {
                Debug.WriteLine("Database could not execute the command and has failed to add the task");
            }

            //end logic
            dbCon.Close();
            Debug.WriteLine("Database close");
        }

        /// <summary>
        /// Will try to remove the task with the ID provided
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteTask(int id)
        {
            string remove = string.Format("Delete from Tasks where id = {0}", id);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(remove, dbCon);
            dbCon.Open();
            Debug.WriteLine("Database open");
            //logic
            try
            {
                dbCom.ExecuteNonQuery();
                dbCom.Dispose();
            }
            catch
            {
                Debug.WriteLine("Database could not execute the command and has failed to remove the task");
            }

            //end logic
            dbCon.Close();
            Debug.WriteLine("Database close");
        }

        public static void DeleteUser(int id, ref TextBox infoBox)
        {
            string deleteUser = "delete from Users where ID= '" + id + "';";
            using (SQLiteConnection c = new SQLiteConnection("Data Source=Data.db;Version=3;"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(deleteUser, c))
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                infoBox.Clear();
                c.Close();
            }
        }

        public static void SelectUser(ref string user, ref int id, ref TextBox infoBox)
        {
            string Query = "select * from Users where name = '" + user + "' ;";
            using (SQLiteConnection c = new SQLiteConnection("data source = Data.db;Version=3;"))
            {
                c.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(Query, c))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string nameString = rdr.GetString(rdr.GetOrdinal("Name"));
                            string userNameString = rdr.GetString(rdr.GetOrdinal("Username"));
                            string workingDaysString = rdr.GetInt32(rdr.GetOrdinal("WorkingDays")).ToString();
                            string cleaningDaysString = rdr.GetInt32(rdr.GetOrdinal("CleaningDays")).ToString();
                            id = rdr.GetInt32(rdr.GetOrdinal("ID"));
                            infoBox.Text = "Navn: " + nameString + "\n" + "Brugernavn: " + userNameString + "\n" + "Arbejdsdage: " + workingDaysString + "\n" + "Rengøringsdage: " + cleaningDaysString;
                        }
                        cmd.Dispose();
                        rdr.Dispose();
                    }
                }
                c.Close();
                c.Dispose();
            }
        }

        public static bool TaskExist(int day, int month, int year)
        {
            string query = "select * from Tasks where day =" + day + ";";
            using (SQLiteConnection c = new SQLiteConnection("data source = Data.db;Version=3;"))
            {
                c.Open();
                try
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            int datamonth = 0;
                            int datayear = 0;
                            while (rdr.Read())
                            {
                                datamonth = rdr.GetInt32(rdr.GetOrdinal("month"));

                                datayear = rdr.GetInt32(rdr.GetOrdinal("year"));
                            }
                            cmd.Dispose();
                            rdr.Dispose();
                            if (datayear == year && datamonth == month)
                            {

                                c.Close();
                                c.Dispose();
                                return true;
                            }
                        }
                    }
                }
                catch
                {
                    // ignored
                }

                c.Close();
                c.Dispose();
            }
            return false;
        }
    }
}