using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOrderManagement.DataLayer
{
    public class Connection
    {
        public static SqlConnection Connect
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection("Server = AHMET\\SQLEXPRESS;Trusted_Connection=True;Database=NORTHWND;TrustServerCertificate=True;");
                return sqlConnection;
            }
        }
    }
}
