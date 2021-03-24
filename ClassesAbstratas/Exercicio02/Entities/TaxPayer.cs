using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public float AnualIncome { get; set; }

        public TaxPayer() { }

        protected TaxPayer(string name, float anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract float Tax();
    }
}
