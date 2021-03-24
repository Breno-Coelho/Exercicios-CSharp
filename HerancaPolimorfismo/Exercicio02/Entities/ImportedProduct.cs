using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class ImportedProduct : Product
    {
        public float CustomsFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, float price, float customsFee)
            : base(name, price)
        {
             CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} {(Price + CustomsFee):C} (Customs fee: {CustomsFee:C})";
        }
    }
}
