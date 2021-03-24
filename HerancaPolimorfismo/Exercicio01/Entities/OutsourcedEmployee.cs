using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class OutsourcedEmployee : Employee
    {
        public float AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, float valuePerHour, float additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override float Payment()
        {
            return ((float)((float)base.Payment() + AdditionalCharge * 0.1 + AdditionalCharge));
        }
    }
}
