using Microsoft.AspNetCore.Mvc;
using ST10263164_CLDV6211_POE.Models;


namespace ST10263164_CLDV6211_POE.Controllers
{
    public class userController : Controller
    {
        users tblUsers = new users();

        [HttpPost]
        public ActionResult Signup(users users)
        {
            var result = tblUsers.userInsert(users);
            return RedirectToAction("Login", "Home");
        }
        [HttpGet]

        public IActionResult Signup()
        {
            return View(tblUsers);
        }
    }
}
