using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }

        public Company() { }
        public Company(int numberEmployees, string name, float anualIncome)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override float Tax()
        {
            if (NumberEmployees > 10 )
            {
                return ((float)(AnualIncome * 0.14));
            }
            else
            {
                return (float)(AnualIncome * 0.16);
            }
        }
    }
}
