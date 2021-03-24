using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public float ValuePerHour { get; private set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, float valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual float Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
