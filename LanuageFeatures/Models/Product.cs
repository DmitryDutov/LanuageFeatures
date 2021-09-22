using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanuageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static Product[] GetProduct()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275M };
            Product lifejacket = new Product { Name = "lifejacket", Price = 48.95M };

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
