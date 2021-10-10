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
            var products = new[]
            {
                  new {Name = "Kaban", Price = 300M }
                , new {Name = "Olen" , Price = 200M }
                , new {Name = "Ejick", Price = 100M }
                , new {Name = "Kotya", Price = 1000M }
            };

            //Старый подход к получению имён:
            //Linq-выражение генерирует строки, каждая из которых имеет жёсткую ссылку на свойства Name и Price
            return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
        }
    }
}

