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
                content.Id = reader["Id"].ToString();
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
        
        public bool AddEvent(Content content, User user)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Contents(Title, Text, DateCreated, DateModified, Phone, Priority) VALUES('"+content.Title+"','"+content.Text+"','"+DateTime.Now.ToString("dd-MM-yyyy")+ "','" + DateTime.Now.ToString("dd-MM-yyyy") + "','"+user.PhoneNumber+"','"+content.Priority+"')");
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

        public bool UpdateEvent(Content content)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("UPDATE Contents SET Title='"+content.Title+"', Text='"+content.Text+"', DateModified='"+content.DateModified+"', Priority='"+content.Priority+"' WHERE Id="+content.Id);
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

        public bool DeleteEvent(string contentId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("DELETE FROM Contents WHERE Id=" + contentId + "; DELETE FROM Images WHERE Id = " + contentId);
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
    }
}
