using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class OrderItem
    {
        public int Quantiy { get; set; }
        public float Price { get; set; }

        public string Product { get; set; }

        public OrderItem(int quantiy, float price)
        {
            Quantiy = quantiy;
            Price = price;
        }

        public float SubTotal()
        {
            return Quantiy * Price;
        }
    }
}
