using mvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc1.Controllers
{
    public class testController : Controller
    {
        // GET: test
        // like this line
        List<Product> products;
        public ActionResult Index()
        {
            products = new List<Product>()
            {
                new Product {ProductId=1,Name="prod1" },
                new Product {ProductId=2,Name="Prod2" }
            };
            return View(products);
        }
        public ActionResult Edit()
        {
            return View();
        }
    }
    
    
}