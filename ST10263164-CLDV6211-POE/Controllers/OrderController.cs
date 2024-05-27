using ST10263164_CLDV6211_POE.Models;
using Microsoft.AspNetCore.Mvc;

namespace ST10263164_CLDV6211_POE.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderModel order;

        public OrderController(OrderModel order)
        {
            this.order = order;
        }

        public IActionResult Orders()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Order(string email, string userPassword)
        {
        
            




            return RedirectToAction("Orders", "Order");
        }
    }
}