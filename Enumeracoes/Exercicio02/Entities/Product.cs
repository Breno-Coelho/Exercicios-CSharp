using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
