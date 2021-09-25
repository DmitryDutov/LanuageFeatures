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
            //Создаём экземпляр ShoppingCart и инициализируем поле Products с помощью метода GetProduct() класса продукт
            ShoppingCart cart = new ShoppingCart{ Products = Product.GetProduct() };
            //используем метод расширения TotalPrice()
            decimal cartTotal = cart.TotalPrice();

            return View("Index", new string[] { $"Total: {cartTotal:C2}" });
        }
    }
}
