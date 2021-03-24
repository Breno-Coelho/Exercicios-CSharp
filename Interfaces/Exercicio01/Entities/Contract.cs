using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public float TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract()
        {
        }

        public Contract(int number, DateTime date, float totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AdicionaParcela(Installment x)
        {
            Installments.Add(x);
        }
    }
}
