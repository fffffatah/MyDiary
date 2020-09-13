using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOperationLib;

namespace DataAccessLib
{
    public class ImageDataAccess
    {
        DatabaseConnection dbConnection;

        public string GetImagePath(string contentId)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("SELECT Image FROM Images WHERE Id='" + contentId + "'");
            string path="";
            SqlDataReader reader = dbConnection.DoQuery();
            if (reader.Read())
            {
                path = reader["Image"].ToString();
            }
            dbConnection.Dispose();
            dbConnection = null;
            return path;
        }

        public bool AddImages(Images images, Content content)
        {
            dbConnection = new DatabaseConnection();
            dbConnection.CreateQuery("INSERT INTO Images(Image, Id) VALUES('"+images.FirstImageLocation+"','"+content.Id+ "')");
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
