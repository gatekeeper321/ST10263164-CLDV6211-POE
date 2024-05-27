using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace ST10263164_CLDV6211_POE.Models
{
    public class OrderModel
    {
        public static string con_string = "Server=tcp:st10263164.database.windows.net,1433;Initial Catalog=st10263164;Persist Security Info=False;User ID=CloudSA2e3d835a;Password=Arsonstahali72;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);
        public int OrderHistory(string email, string userPassword)
        {

            return 0;
        }
    }
}
