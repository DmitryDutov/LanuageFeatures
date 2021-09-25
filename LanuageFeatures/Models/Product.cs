using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        //Инициализация
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        //Инициализация
        public bool InStock { get; } = true;
        public Product(bool stock = true) { InStock = stock; }

        public static Product[] GetProduct()
        {
            //Инициализация объекта:
            Product kayak = new Product { 
                  Name = "Kayak"
                , Category = "Water Craft"
                , Price = 275M 
            };
            Product lifejacket = new Product(false) { 
                  Name = "lifejacket"
                , Price = 48.95M 
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}

