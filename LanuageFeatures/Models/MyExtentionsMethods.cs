using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public static class MyExtentionsMethods
    {
        //Ключевое слово this помечает метод TotalPrice как метод расширения для ShoppingCart
        //на экземпляр ShoppingCart к которому применён метод расширения можно ссылаться с использованием параметра cartParam
        public static decimal TotalPrice(this ShoppingCart cartParam) //в качестве параметра передаём экземпляр ShoppingCart
        {
            decimal total = 0;
            foreach (Product prod in cartParam.Products)
            {
                total += prod?.Price ?? 0;
            }

            return total;
        }

    }
}
