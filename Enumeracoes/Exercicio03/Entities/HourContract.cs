using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public float ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract(DateTime date, float valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public float TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
