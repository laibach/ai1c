using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Text;

namespace AllInOneCase
{
    internal class SQLiteWrapper
    {
        // Enlist=N

        public static String SQLiteConnectionString = "Database=c:\\AI1C\\AIOC.db;Version=3;DRIVER=SQLite3 ODBC Driver;LongNames=0;Timeout=1000;NoTXN=0;SyncPragma=NORMAL;StepAPI=0;Pooling=True;Max Pool Size=100;Journal Mode=Off;";
        public static OdbcConnection MyConnection;

        // public SQLiteWrapper();

        public static System.Data.Odbc.OdbcDataReader doSQL(String SQLString)
        {
            MyConnection = SQLiteWrapper.openODBC(SQLiteConnectionString);

            return (SQLiteWrapper.GetData(MyConnection, SQLString));
        }

        public static OdbcConnection openODBC(String ODBCConnectionString)
        {
            if (MyConnection == null || MyConnection.State != ConnectionState.Open)
            {
                MyConnection = (new OdbcConnection());
                MyConnection.ConnectionString = ODBCConnectionString;
                MyConnection.Open();
            }
            else
            {
            }
            return (MyConnection);
        }

        public static void closeODBC()
        {
            MyConnection.Close();
        }

        public static OdbcDataReader GetData(OdbcConnection ODBCConnection, String SQLString)
        {
            OdbcCommand ODBCcmd;

            ODBCcmd = new OdbcCommand();

            ODBCcmd.Connection = ODBCConnection;

            ODBCcmd.CommandText = SQLString;

            ODBCcmd.CommandTimeout = 3000000;
            ODBCcmd.CommandType = System.Data.CommandType.Text;
            ODBCcmd.Transaction = null;
            ODBCcmd.UpdatedRowSource = UpdateRowSource.None;

            OdbcDataReader dr = null;
            try
            {
                dr = ODBCcmd.ExecuteReader();
            }
            catch
            {
                // Fehlermeldung
            }

            // return (ODBCcmd.ExecuteReader());
            return dr;
        }

        public static void SetData(OdbcConnection ODBCConnection, String SQLString)
        {
            OdbcCommand ODBCcmd;

            ODBCcmd = new OdbcCommand();

            ODBCcmd.Connection = ODBCConnection;

            ODBCcmd.CommandText = SQLString;

            ODBCcmd.CommandTimeout = 3000000;
            ODBCcmd.CommandType = CommandType.Text;
            ODBCcmd.Transaction = null;
            ODBCcmd.UpdatedRowSource = UpdateRowSource.None;

            ODBCcmd.ExecuteNonQuery();
        }

        public static void OdbcDataExecuter(String SQLString)
        {
            MyConnection = SQLiteWrapper.openODBC(SQLiteConnectionString);
            SQLiteWrapper.SetData(MyConnection, SQLString);
        }

        public static String checkStringforOdbc(String Text)
        {
            Text = Text.Replace("'", "`");
            Text = Text.Replace("\"", "´");

            return (Text);
        }
    }
}