using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CO453_WebApplication.Models;

namespace CO453_WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private MenuList menu = new MenuList();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Customer()
        {

            Customer customer = new Customer
            {
                ID = 1,
                FullName = "Derek",
                Email = "derek@gmail.com",
                MobileNumber = "07896 234 678"
            };


            return View(customer);
        }

        [HttpPost]
        public IActionResult Customer(Customer customer)
        {
            // Save customer to database
            ViewBag.Customer = customer;

            return RedirectToAction("Index");
        }

        public IActionResult Menu()
        {
            var model = menu.GetDishes();

            return View(model);
        }

        public IActionResult Select(int id)
        {
            // Uses LINQ and a Lambda Expression

            Dish dish = menu.GetDishes().FirstOrDefault(d => d.ID == id);

            MealOrder meal = new MealOrder();
            meal.Starter = dish;

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
