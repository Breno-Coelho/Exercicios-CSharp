using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Individual : TaxPayer
    {
        public float HealthExpenditures { get; set; }


        public Individual() { }
        public Individual(float healthExpenditures, string name, float anualIncome)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override float Tax()
        {
            if (AnualIncome < 20000)
            {
                return (float)((AnualIncome * 0.15) - (HealthExpenditures * 0.5));
            }
            else
            {
                return (float)((AnualIncome * 0.25) - (HealthExpenditures * 0.5));
            }
        }
    }
}
