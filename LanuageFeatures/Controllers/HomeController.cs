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
            var products = new[] {
                   //каждый объект в массиве products имеет анонимный тип
                   new {Name = "Kayak"       , Price = 275M }
                  ,new {Name = "Lifejacket"  , Price = 48.25M }
                  ,new {Name = "Soccer ball" , Price = 19.50M }
                  ,new {Name = "Conter flag" , Price = 34.95M }
            };

            //Отображение типа объекта по свойству
            return View(products.Select(p => p.GetType().Name));
        }
    }
}

