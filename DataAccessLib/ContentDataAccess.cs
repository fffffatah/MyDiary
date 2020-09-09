using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperationLib;

namespace DataAccessLib
{
    public class ContentDataAccess
    {
        DatabaseConnection dbConnection;

        public List<Content> GetContents(string phoneNumber)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT * FROM Contents WHERE Phone='" +phoneNumber+ "'");
            List<Content> list = new List<Content>();
            SqlDataReader reader = dbConnection.DoQuery();
            while (reader.Read())
            {
                Content content = new Content();
                content.Title = reader["Title"].ToString();
                content.Text = reader["Text"].ToString();
                content.DateCreated = reader["DateCreated"].ToString();
                content.DateModified = reader["DateModified"].ToString();
                content.Priority = reader["Priority"].ToString();
                list.Add(content);
            }
            dbConnection.Dispose();
            dbConnection = null;
            return list;
        }
        
        public bool AddEvent()
        {
            //TODO
            return false;
        }

        public bool UpdateEvent()
        {
            //TODO
            return false;
        }
    }
}
