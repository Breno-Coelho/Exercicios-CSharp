using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, float price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return $"{Name} (usado) {Price:C} ({ManufactureDate})";
        }
    }
}
