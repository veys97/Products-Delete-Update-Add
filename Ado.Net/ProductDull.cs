using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;



namespace Ado.Net
{
    public class ProductDull
    {
      public List<Product> GetAll()
        {
            SqlConnection connection = ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product prd = new Product
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                products.Add(prd);

            }
            reader.Close();
            connection.Close();
            return products;
        }

        private static SqlConnection ConnectionControl()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=false;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=false;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
        public void Add(Product product)
        {
            SqlConnection connection = ConnectionControl();
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)",connection);
            cmd.Parameters.AddWithValue("@name",product.Name);
            cmd.Parameters.AddWithValue("@unitPrice",product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount",product.StockAmount);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Update(Product product)
        {
            SqlConnection connection = ConnectionControl();
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Update Products set Name = @name, unitPrice = @unitPrice, stockAmount = @stockAmount where Id = @id", connection);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.Parameters.AddWithValue("@id", product.ID);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int id)
        {
            SqlConnection connection = ConnectionControl();
            ConnectionControl();
            SqlCommand cmd = new SqlCommand("Delete from Products where Id = @id", connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
