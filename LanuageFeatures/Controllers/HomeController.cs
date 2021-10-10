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

            //Новый подход к получению имён:
            //вместо ручного присваивания получаем имя свойства автоматически
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }
    }
}

