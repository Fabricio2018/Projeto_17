using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Linq.Entities
{
    class Products
    {
        public string  Name { get; set; }
        public double Price { get; set; }

        public Products(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
