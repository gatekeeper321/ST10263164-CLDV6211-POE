using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;

namespace ST10263164_CLDV6211_POE.Models
{
    public class Products
    {
        public static string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        public int productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public string productCatergory { get; set; }
        public string productDescription { get; set; }
        public bool productAvailability { get; set; }
        public byte[] productImg { get; set; }

        public int ProductInsert(Products p)
        {
            try
            {
                string sql = "INSERT INTO products (productName, productPrice, productCatergory, productDescription, productAvailability, productImg) VALUES (@productName, @productPrice, @productCategory, @productDescription, @productAvailability, @productImg)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@productName", p.productName);
                cmd.Parameters.AddWithValue("@productPrice", p.productPrice);
                cmd.Parameters.AddWithValue("@productCategory", p.productCatergory);
                cmd.Parameters.AddWithValue("@productDescription", p.productDescription);
                cmd.Parameters.AddWithValue("@productAvailability", p.productAvailability);
                cmd.Parameters.AddWithValue("@productImg", p.productImg);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
