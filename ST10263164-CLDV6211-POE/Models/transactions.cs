using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;

namespace ST10263164_CLDV6211_POE.Models
{
    
    public class transactions
    {
        /*
        public static string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        public int transactionID { get; set; }
        public int userID { get; set; }
        public DateOnly date { get; set; }

        public int TransactionInsert(transactions t)
        {
            Products products = new Products();
            LoginModel loggedin = new LoginModel();

            userID = loggedin.userId;
            
            try
            {
                
                string sql = "SELECT userID FROM users WHERE email = @email AND userPassword = @userPassword";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@userPassword", userPassword);

                string sql = "INSERT INTO transactions (date) VALUES (@date)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@date", t.date);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                    
                
                string sql1 = "INSERT INTO transactions (date) VALUES (@date)";
                SqlCommand cmd1 = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@date", t.date);
                con.Open();
                int rowsAffected1 = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    */
    }
    
}