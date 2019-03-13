using HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Controllers
{
    public class HomeController : Controller
    {
        //declare global variables
        string[] balloons = { "Red", "Blue", "Green", "Purple" };

        List<Product> Products = new List<Product>() {
            new Product{ Id = "000", Name= "Fallout 76 Action Figure", Price = 1.99 },
            new Product{ Id = "001", Name= "Xbox One", Price = 300.00 },
            new Product{ Id = "002", Name= "Microfiber Cloth", Price = 5.23 },
            new Product{ Id = "003", Name= "Pet Rock", Price = 7.87 },
            new Product{ Id = "004", Name= "Xbox Game Collection", Price = 100.00}
        };

        List<Discount> Discounts = new List<Discount>()
        {
            new Discount{ Id = "000", Name= "First purchase", Price = 20.00 },
            new Discount{ Id = "001", Name= "Xbox", Price = 30.00 },
            new Discount{ Id = "000", Name= "Xbox pack", Price = 50.00 }
        };

        public ActionResult DisplayProducts()
        {
          //  ViewBag.Products = Products;
            return View(Products);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult DisplayDiscounts()
        {
            List<Discount> discounts = new List<Discount>();
            
            for(int i = 0; i < Discounts.Count(); i++)
            {
                    discounts.Add(Discounts[i]);
            }
            ViewBag.Discounts = discounts;
            return View();
        }

        [HttpPost]
        public ActionResult ProcessOrder(FormCollection form)
        {
            List<Order> orders = new List<Order>();

            foreach(Product p in Products)
            {
                int qty = Convert.ToInt32(form[p.Id]);

                if (qty > 0)
                {
                    orders.Add(new Order { Prod = p, Qty = qty });
                }
            }

            ViewBag.Orders = orders;
            return View();
        }
    }
}