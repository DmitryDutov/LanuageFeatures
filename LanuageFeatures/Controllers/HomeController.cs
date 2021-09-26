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
        bool FilterByPrice (Product p)
        {
            return (p?.Price ?? 0) >= 150;
        }

        public ViewResult Index()
        {
            //Инициализируем продукты в корзине
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProduct() };

            //Инициализируем массив продуктов
            Product[] productArray =
            {
                  new Product{Name="Kayak"      , Category="Cat001", Price = 500M }
                , new Product{Name="LifeJacket" , Category="Cat002", Price = 300M }
                , new Product{Name="Product-001", Category="Cat001", Price = 100M }
                , new Product{Name="Product-002", Category="Cat001", Price = 150M }
                , new Product{Name="Product-003", Category="Cat001", Price = 200M }
            };

            Func<Product, bool> nameFilter = delegate (Product prod)
            {
                return prod?.Name?[0] == 'L';
            };

            //вычисляем общую стоимость в обоих случаях
            decimal cartTotal  = cart.TotalPrice();
            decimal arrayTotal = productArray.TotalPrice();

            //Общий прайс с фильтром
            decimal priceFilterTotal = productArray.FilterByPrice(200).TotalPrice();
            //Общий прайс с фильтром по имени
            decimal nameFilterTotal  = productArray.FilterByName('P').TotalPrice();

            //Универсальный фильтр
            decimal uniPriceFilterTotal = productArray.Filter(FilterByPrice).TotalPrice();
            decimal uniNameFilterTotal  = productArray.Filter(nameFilter).TotalPrice();
            

            //выводим информацию на View
            return View("Index", new string[] {
                  $"Cart Total: {cartTotal:C2}" 
                , $"Arry Total: {arrayTotal:C2}"
                , $"Price Filter Total: {priceFilterTotal:C2}"
                , $"Name Filter Total: {nameFilterTotal:C2}"
                , $"UniPrice Filter Total: {uniPriceFilterTotal:C2}"
                , $"UniName Filter Total: {uniNameFilterTotal:C2}"
            });
        }
    }
}
