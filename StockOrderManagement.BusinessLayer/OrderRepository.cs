using StockOrderManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOrderManagement.BusinessLayer
{
    public class OrderRepository
    {
        public int EmployeeID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }

        public bool Save()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("insert into Orderss values (@EmployeeID,@ProductID,@Quantity)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                sqlCommand.Parameters.AddWithValue("@ProductID", ProductID);
                sqlCommand.Parameters.AddWithValue("@Quantity", Quantity);

                sqlConnection.Open();
                int affectedRows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                return affectedRows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataReader Select()
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from VW_OrderList", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }
    }
}
