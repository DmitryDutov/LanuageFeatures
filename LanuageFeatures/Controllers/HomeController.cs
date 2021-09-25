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
    //Демонстрация рабты метода расширения как для класса Product так и для класса ShoppingCart
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //Инициализируем продукты в корзине
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };

            //Инициализируем массив продуктов
            Product[] productArray =
            {
                  new Product{Name="Kayak"      , Category="Cat001", Price = 500M }
                , new Product{Name="LifeJacket" , Category="Cat002", Price = 50M }
                , new Product{Name="Product-001", Category="Cat001", Price = 150M }
            };

            //вычисляем общую стоимость в обоих случаях
            decimal cartTotal   = cart.TotalPrice();
            decimal arrayTotal  = productArray.TotalPrice();

            //выводим информацию на View
            return View("Index", new string[] {
                  $"Cart Total: {cartTotal:C2}" 
                , $"Arry Total: {arrayTotal:C2}"
            });
        }
    }
}
