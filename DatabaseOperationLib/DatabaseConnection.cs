using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseOperationLib
{
    public static class DatabaseConnection
    {
        static SqlConnection con;
        static SqlCommand command;

        public static void InitiateConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["AzureDb"].ConnectionString);
            con.Open();
            command.Connection = con;
        }

        public static void CloseConnection()
        {
            con.Close();
            command.Dispose();
            con.Dispose();
        }

        public static SqlDataReader Query(string sql)
        {
            command.CommandText = sql;
            return command.ExecuteReader();
        }

        public static int NonQuery(string sql)
        {
            command.CommandText = sql;
            return command.ExecuteNonQuery();
        }
    }
}
