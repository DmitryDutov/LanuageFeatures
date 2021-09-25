using LanuageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Другой способ инициализации с помощью словаря
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product {Name = "Kayak", Category = "New Category", Price = 275M},
                ["Lifejacket"] = new Product{Name="Lifejacet", Category = "Jacket", Price = 48.95M }
            };

            return View("Index", products.Keys);
        }
    }
}
