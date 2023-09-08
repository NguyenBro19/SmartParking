using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doanthu2
{
    class ConnectDB
    {
        OleDbConnection myConnection = new OleDbConnection();

        public void Connect()
        {

            try
            {
                myConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CSDL.accdb;";
                myConnection.Open();
            }
            catch { }

        }



        public OleDbDataReader SelectSQL(String sql)
        {
            OleDbCommand cmd = myConnection.CreateCommand();
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader();
            cmd.Dispose();
            return reader;
        }


        public int UpdateSQL(String sql)
        {
            OleDbCommand cmd = myConnection.CreateCommand();
            cmd.CommandText = sql;
            int result = cmd.ExecuteNonQuery();
            cmd.Dispose();
            return result;
        }


        public void Close()
        {
            try
            {
                if (myConnection != null && myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
            catch { }
        }
    }
}
