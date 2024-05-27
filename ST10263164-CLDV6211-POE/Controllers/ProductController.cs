using Microsoft.AspNetCore.Mvc;
using ST10263164_CLDV6211_POE.Models;
using ST10263164_CLDV6211_POE.Controllers;
using System.Collections.Generic;

namespace ST10263164_CLDV6211_POE.Controllers
{
    public class ProductController : Controller
    {
        private readonly Products tblProducts = new Products();

        [HttpGet]
        public ActionResult MyWork()
        {
            List<ProductDisplayModel> products = ProductDisplayModel.SelectProducts();

            if (products == null)
            {
                products = new List<ProductDisplayModel>();
            }

            return View(products);
        }

        [HttpPost]
        public ActionResult AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                var result = tblProducts.ProductInsert(product);
                return RedirectToAction("MyWork");
            }
            else
            {
                return View("AddProduct");
            }
        }
    }
}
