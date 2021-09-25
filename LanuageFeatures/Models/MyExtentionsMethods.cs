using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public static class MyExtentionsMethods
    {
        //Ключевое слово this помечает метод TotalPrice как метод расширения для множества Prosuct
        //на экземпляр множества к которому применён метод расширения можно ссылаться с использованием параметра products
        public static decimal TotalPrice(this IEnumerable<Product> products) //в качестве параметра передаём экземпляр перечисления множества Product'ов
        {
            decimal total = 0;
            foreach (Product prod in products)
            {
                total += prod?.Price ?? 0;
            }

            return total;
        }

    }
}
