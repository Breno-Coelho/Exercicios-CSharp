using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public float Amount { get; set; }

        public Installment(DateTime dueDate, float amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}
