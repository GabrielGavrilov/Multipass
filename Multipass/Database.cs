using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Newtonsoft.Json.Linq;

namespace Multipass
{
    public class Database
    {

        static string _dbConnectionUrl = @"URI=file:C:\Multipass\Multipass.db";
        
        public static void dbCreateTable()
        {
            var connection = new SQLiteConnection(_dbConnectionUrl);
            var cmd = new SQLiteCommand(connection);
            connection.Open();

            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Accounts(
                ID INTEGER PRIMARY KEY,
                EMAIL TEXT,
                USERNAME TEXT,
                PASSWORD TEXT,
                WEBSITE_URL TEXT)";

            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void saveNewAccount(string email, string username, string password, string websiteUrl)
        {
            var connection = new SQLiteConnection(_dbConnectionUrl);
            var cmd = new SQLiteCommand(connection);
            connection.Open();

            cmd.CommandText = @"INSERT INTO Accounts(EMAIL, USERNAME, PASSWORD, WEBSITE_URL) VALUES( '" + email +
                "', '" + username + "', '" + password +"', '" + websiteUrl + "')";

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        
        public static string findSavedAccount(string websiteUrl)
        {
            string data = "";
            var connection = new SQLiteConnection(_dbConnectionUrl);
            connection.Open();
            string find = @"SELECT *
                            FROM Accounts
                            WHERE WEBSITE_URL = '" + websiteUrl + "'";
            var cmd = new SQLiteCommand(find, connection);
            SQLiteDataReader results = cmd.ExecuteReader();

            while(results.Read())
            {
                data = "ACCOUNT EMAIL:  " + results.GetString(1) + "\n" +
                    "ACCOUNT USERNAME:  " + results.GetString(2) +"\n" +
                    "ACCOUNT PASSWORD:  " + results.GetString(3);
            }

            return data;
        }

    }
}
