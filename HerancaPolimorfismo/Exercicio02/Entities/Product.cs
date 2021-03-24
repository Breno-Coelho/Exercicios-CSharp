using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

        public Product() { }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public virtual string priceTag()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
