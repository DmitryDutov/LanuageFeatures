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
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProduct())
            {
                string name = p?.Name;
                decimal? price = p?.Price;

                results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            }
            return View(new string[] { "C#", "Language", "Features" });
        }
    }
}
