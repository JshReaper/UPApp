using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace BookingSystem
{
    static class DatabaseManager
    {

        public static void GenerateDataBase()
        {

            if (!File.Exists("Data.db"))
            {
                SQLiteConnection.CreateFile("Data.db");
                SQLiteConnection dbConnOnCreate = new SQLiteConnection("Data Source=Data.db;Version=3;");
                dbConnOnCreate.Open();


                //initial logic
                string userTable = "create table Users (id integer primary key, Username string, Password string, Name string, IsAdmin bool)";
                SQLiteCommand commandOnCreate = new SQLiteCommand(userTable, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();
                string user = "Insert into Users values(null, \"admin\", \"admin\", \"ADMINISTRATOR\", 1)";
                commandOnCreate = new SQLiteCommand(user, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();
                string workTable = "create table Tasks (id integer primary key, day integer, month integer, year integer, assignee integer, type bool, start string, end string )";
                commandOnCreate = new SQLiteCommand(workTable, dbConnOnCreate);
                commandOnCreate.ExecuteNonQuery();


                //end logic
                dbConnOnCreate.Close();

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
                    Debug.WriteLine("User was not found");
                    return false;
                }
                if (dr.GetString(1) == Username && dr.GetString(2) == Password)
                {
                    dbCon.Close();
                    Debug.WriteLine("User is now logged in");
                    return true;
                }
            }
            //end logic
            dbCon.Close();
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

            string add = string.Format("insert into Tasks values(null,{0},{1},{2},0,{3},{4},{5} )", day, month, year, clean,start,end);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(add, dbCon);
            dbCon.Open();
            Debug.WriteLine("Database open");
            //logic
            try
            {
                dbCom.ExecuteNonQuery();
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
            }
            catch
            {
                Debug.WriteLine("Database could not execute the command and has failed to remove the task");
            }

            //end logic
            dbCon.Close();
            Debug.WriteLine("Database close");
        }
    }
}