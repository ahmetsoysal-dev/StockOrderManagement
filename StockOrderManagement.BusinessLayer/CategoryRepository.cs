using StockOrderManagement.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockOrderManagement.BusinessLayer
{
    public class CategoryRepository
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // kaydet metodu
        public bool Save()
        {
            try
            {
                // Bağlantı yapılıyor
                SqlConnection sqlConnection = Connection.Connect;

                // Tanımlıyor
                SqlCommand sqlCommand = new SqlCommand("insert into Categories (CategoryName) values (@CategoryName)", sqlConnection);

                // property deki değeri @CategoryName değişkenine veriyorum.
                sqlCommand.Parameters.AddWithValue("@CategoryName", CategoryName);

                sqlConnection.Open();  // bağlantıyı aç
                int affectedRows = sqlCommand.ExecuteNonQuery(); // tetikle
                sqlConnection.Close();  // bağlantıyı kapat

                return affectedRows > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ctrl + M + O = kapalı metodları açıp kapatmak için
        // ctrl + M + L = acık

        public SqlDataReader Select()
        {
            SqlConnection sqlConnection = Connection.Connect;

            SqlCommand sqlCommand = new SqlCommand("select * from Categories order by CategoryName", sqlConnection);

            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            return sqlDataReader;
        }

        public bool Update()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("update Categories set CategoryName = @CategoryName where CategoryID = @CategoryID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CategoryID", CategoryID);
                sqlCommand.Parameters.AddWithValue("@CategoryName", CategoryName);

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

        public bool Delete()
        {
            try
            {
                SqlConnection sqlConnection = Connection.Connect;

                SqlCommand sqlCommand = new SqlCommand("delete from Categories where CategoryID = @CategoryID", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@CategoryID", CategoryID);

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
        public int FindID(string CategoryName)
        {
            var sqlConnection = Connection.Connect;
            var sqlCommand = new SqlCommand($"SELECT CategoryID FROM Categories WHERE CategoryName = @CategoryName", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CategoryName", CategoryName);
            sqlConnection.Open();

            var sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            var categoryID = Convert.ToInt32(sqlDataReader[0]);
            sqlConnection.Close();
            return categoryID;
        }
    }
}
