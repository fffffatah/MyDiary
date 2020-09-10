using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseOperationLib;

namespace DataAccessLib
{
    public class UserDataAccess
    {
        DatabaseConnection dbConnection;
        public bool CreateUser(User user)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Users(FirstName, LastName, Pass, Phone) VALUES('" + user.FirstName + "','" + user.LastName + "','" + user.Password + "','" + user.PhoneNumber + "')");
            if ((dbConnection.DoNoQuery()) < 1)
            {
                dbConnection.Dispose();
                dbConnection = null;
                return false;
            }
            dbConnection.Dispose();
            dbConnection = null;
            return true;
        }

        public User GetUser(string phoneNumber, string pass)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Users WHERE Pass='" + pass + "' AND Phone='" + phoneNumber + "'");
            SqlDataReader reader = dbConnection.DoQuery();
            User user = new User();
            while(reader.Read())
            {
                user.FirstName = reader["FirstName"].ToString();
                user.LastName = reader["LastName"].ToString();
                user.PhoneNumber = reader["Phone"].ToString();
            }
            dbConnection.Dispose();
            dbConnection = null;
            return user;
        }

        public bool DoesPhoneNumberExists(string phoneNumber)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT Phone FROM Users WHERE Phone='" + phoneNumber + "'");
            SqlDataReader reader = dbConnection.DoQuery();
            bool flag = reader.HasRows;
            dbConnection.Dispose();
            dbConnection = null;
            return flag;
        }
    }
}
