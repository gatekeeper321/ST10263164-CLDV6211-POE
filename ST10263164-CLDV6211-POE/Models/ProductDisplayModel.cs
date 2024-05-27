using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace ST10263164_CLDV6211_POE.Models
{
    public class ProductDisplayModel
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public decimal productPrice { get; set; }
        public string productCatergory { get; set; }
        public string productDescription { get; set; }
        public bool? productAvailability { get; set; }
        public byte[] productImg { get; set; }

        public ProductDisplayModel()
        {
            productID = 0;
            productName = string.Empty;
            productPrice = 0;
            productCatergory = string.Empty;
            productDescription = string.Empty;
            productAvailability = true;
            productImg = null;
        }

        public static List<ProductDisplayModel> SelectProducts()
        {
            List<ProductDisplayModel> products = new List<ProductDisplayModel>();

            string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
            using (SqlConnection con = new SqlConnection(con_string))
            {
                string sql = "SELECT productID, productName, productPrice, productCatergory, productDescription, productAvailability, productImg FROM products";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProductDisplayModel product = new ProductDisplayModel
                    {
                        productID = Convert.ToInt32(reader["productID"]),
                        productName = reader["productName"].ToString(),
                        productPrice = Convert.ToDecimal(reader["productPrice"]),
                        productCatergory = reader["productCatergory"].ToString(),
                        productDescription = reader["productDescription"].ToString(),
                        productAvailability = reader["productAvailability"] as bool?,
                        productImg = reader["productImg"] as byte[]
                    };
                    products.Add(product);
                    Console.WriteLine(product.productName);
                }
                reader.Close();
            }
            return products;
        }
    }
} 