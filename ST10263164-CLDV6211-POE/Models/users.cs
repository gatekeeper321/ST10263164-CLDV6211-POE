using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ST10263164_CLDV6211_POE.Models
{
    public class users
    {
        public static string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        public int userID { get; set; }
        public string userPassword { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }

        public int userInsert(users u)
        {
            try
            {
                string sql = "INSERT INTO users (userPassword, name, surname, email) VALUES (@userPassword, @name, @surname, @email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@userPassword", u.userPassword);
                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@surname", u.surname);
                cmd.Parameters.AddWithValue("@email", u.email);
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
