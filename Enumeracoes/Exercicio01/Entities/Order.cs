using System;
using System.Collections.Generic;
using System.Text;
using Exercicio01.Entities.Enums;

namespace Exercicio01.Entities
{
    class Order
    {

        public int Id { get; set; }
        public DateTime Moment  { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return "Id: " + Id + "Hora: " + Moment + "Status: " + Status;
        }
    }
}
