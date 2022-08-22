using app2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace app2.Controllers
{
    public class TasksController : Controller
    {
        public TasksController()
        { }
        IList<Product> prodList = new List<Product>() { 
             new Product { name = "milk", price = 11},
             new Product { name = "bread", price = 10 },
             new Product { name = "cheese", price =140},
             new Product { name = "sausage", price =110},
             new Product { name = "potato", price = 7 },
             new Product { name = "banana", price = 23 },
             new Product { name = "tomato", price = 25 },
             new Product { name = "candy", price = 75 }
        };
        public IActionResult Greetings()
        {
            DateTime date = DateTime.Today;
            ViewBag.day = date.DayOfWeek;
            DateTime time = DateTime.Now;
            if ( ( time.Hour >= 4 ) & (time.Hour <= 10 )) { ViewBag.greet = "Good Morning"; }
            else { ViewBag.greet = "Good Evening"; }
            return View();
        }
        public IActionResult ProductInfo()
        {
            ViewBag.prod =  prodList;
            return View();

        }
        public IActionResult ShoppingCart()
        {
            return View();

        }
        public IActionResult ShoppingList()
        {
            return View();

        }
        public IActionResult Supermarkets()
        {
            var stringArray = new string[] { "Wellmart", "Silpo", "ATB" , "Furshet", "Metro"};
            ViewBag.Collection = stringArray;
            ViewBag.count = stringArray.Length;

            return View();

        }
    }
}
