using Microsoft.AspNetCore.Mvc;
using ST10263164_CLDV6211_POE.Models;

namespace ST10263164_CLDV6211_POE.Controllers
{
    public class ProductDisplayController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var products = ProductDisplayModel.SelectProducts();
            return View(products);
        }
    }
}

