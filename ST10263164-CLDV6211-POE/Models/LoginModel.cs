using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ST10263164_CLDV6211_POE.Models
{
    public class LoginModel
    {
        public int userId;

        public static string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);
        public int SelectUser(string email, string userPassword)
        {
            userId = -1; // Default value if user is not found
            using (SqlConnection con = new SqlConnection(con_string))
            {
                string sql = "SELECT userID FROM users WHERE email = @email AND userPassword = @userPassword";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@userPassword", userPassword);
                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
                catch (Exception)
                {
                    // Log the exception or handle it appropriately
                    // For now, rethrow the exception without changing the stack information
                    throw;
                }
            }
            return userId;
        }
    }
}

