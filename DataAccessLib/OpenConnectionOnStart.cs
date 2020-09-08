using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLib
{
    public class OpenConnectionOnStart
    {
        public static void Open()
        {
            DatabaseOperationLib.DatabaseConnection.InitiateConnection();
        }

        public static void Close()
        {
            DatabaseOperationLib.DatabaseConnection.CloseConnection();
        }
    }
}
