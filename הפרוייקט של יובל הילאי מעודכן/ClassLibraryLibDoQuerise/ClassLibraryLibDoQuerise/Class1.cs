using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Collections;
using System.Data;


namespace ClassLibraryLibDoQuerise
{
    public class DoQueries
    {
        public DoQueries()
        {
        }
        public static DataTable GetDataTableByDataReader(string strConnection, string strSQLName)
        {

            OleDbConnection cnn = new OleDbConnection(strConnection);
            OleDbCommand cmd = new OleDbCommand(strSQLName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            cnn.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            cnn.Close();
            return dt;
        }

        public static DataTable GetDataTableByDataReader(string strConnection, string strSQLName, ArrayList prmList)
        {
            OleDbConnection cnn = new OleDbConnection(strConnection);
            OleDbCommand cmd = new OleDbCommand(strSQLName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (OleDbParameter prm in prmList)
            {
                cmd.Parameters.Add(prm);
            }
            OleDbDataReader dr = null;
            DataTable dt = new DataTable();
            cnn.Open();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            cnn.Close();

            return dt;
        }


        public static bool ExecuteSPNonQuery(string strConnection, string strSQLName, ArrayList prmList)
        {
            OleDbConnection cnn = new OleDbConnection(strConnection);

            OleDbCommand cmd = new OleDbCommand(strSQLName, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (OleDbParameter prm in prmList)
            {
                cmd.Parameters.Add(prm);
            }

            bool execute = false;
            cnn.Open();
            execute = (cmd.ExecuteNonQuery() != 0);
            cnn.Close();

            return execute;
        }



    }
}
