using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ConsoleApp1.Common;

namespace ConsoleApp1.Data
{
    public class ProductData
    {
        public List<Product> GetAll()
        {
            var productList = new List<Product>();
            SqlConnection con = Database.GetConnection();
            con.Open();
            using (con)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Select * From product";
                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Product product = new Product((int)reader.GetValue(0), (string)reader.GetValue(1), (decimal)reader.GetValue(2), (int)reader.GetValue(3));
                        productList.Add(product);
                    }
                }
            }
            con.Close();
            return productList;

        }
        public Product Get(int id)
        {
            Product product = null;
            SqlConnection con = Database.GetConnection();
            con.Open();
            using (con)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "Select * from product where id=@id";
                command.CommandText
            }
        }
    }
}
