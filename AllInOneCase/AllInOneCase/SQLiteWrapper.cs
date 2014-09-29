using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SQLite;
using System.Text;

namespace AllInOneCase
{
    internal class SQLiteWrapper
    {
        SQLiteConnection sconnection;
        String SQLiteDB = "m4lw4r.db";
        String sSQLiteConnectionString = "";
        private void openConnection()
        {
            if (!System.IO.File.Exists(SQLiteDB))
                SQLiteConnection.CreateFile(SQLiteDB);

            sSQLiteConnectionString = "Data Source=" + SQLiteDB + ";Version=3;";
            sconnection = new SQLiteConnection(sSQLiteConnectionString);
            sconnection.Open();
        }

        public SQLiteDataReader doSQL(String SQLStatement)
        {
            if (sconnection == null)
                openConnection();

            if (sconnection.State != System.Data.ConnectionState.Open)
                openConnection();

            SQLiteCommand command = new SQLiteCommand(SQLStatement, sconnection);
            return command.ExecuteReader();
        }

        public void closeConnection()
        {
            sconnection.Close();
        }

        public static String checkStringforOdbc(String Text)
        {
            Text = Text.Replace("'", "`");
            Text = Text.Replace("\"", "´");

            return (Text);
        }
    }
}