using ST10263164_CLDV6211_POE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ST10263164_CLDV6211_POE.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginModel login;

        public LoginController(LoginModel login)
        {
            this.login = login;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string userPassword)
        {
            int userID = login.SelectUser(email, userPassword);
            if (userID != -1)
            {
                // Store userID in session
                HttpContext.Session.SetInt32("UserID", userID);

                // User found, proceed with login logic (e.g., set authentication cookie)
                // For demonstration, redirecting to a dummy page
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // User not found, handle accordingly (e.g., show error message)
                return View("LoginFailed");
            }
        }
    }
} 
