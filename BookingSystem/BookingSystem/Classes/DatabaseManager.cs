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


                //end logic
                dbConnOnCreate.Close();

            }
        }

        public static bool Authenticate(string Username, string Password)
        {
            string retriver = string.Format("Select * from Users where Username = {0}", Username);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(retriver, dbCon);
            dbCon.Open();
            //logic
            SQLiteDataReader dr;
            dr = dbCom.ExecuteReader();
            
            dr.Read();
            if (dr.GetString(1) != Username)
            {
                dbCon.Close();
                Debug.WriteLine("User was not found");
                return false;
            }
            if(dr.GetString(1) == Username && dr.GetString(2) == Password)
            {
                dbCon.Close();
                Debug.WriteLine("User is now loggedin");
                return true;
            }

            //end logic
            dbCon.Close();
            Debug.WriteLine("Logic has failed");            
            return false;
        }

        public static int FindID(string Username)
        {
            string retriver = string.Format("Select * from Users where Username = {0}", Username);
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=Data.db;Version=3;");
            SQLiteCommand dbCom = new SQLiteCommand(retriver, dbCon);
            dbCon.Open();
            //logic
            SQLiteDataReader dr = dbCom.ExecuteReader();
            dr.Read();


            //end logic
            dbCon.Close();
            return dr.GetInt32(0);
        }
    }
}
