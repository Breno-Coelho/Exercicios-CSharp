using Exercicio02.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem x)
        {
            Items.Add(x);
        }

        public void RemoveItem(OrderItem x)
        {
            Items.Remove(x);
        }

        public float Total()
        {
            float soma = 0;
            foreach(OrderItem i in Items)
            {
                soma += i.SubTotal();
            }
            return soma;
        }
     
           
        public override string ToString()
        {
            StringBuilder x = new StringBuilder();
            x.AppendLine("Resumo do pedido: ");
            x.AppendLine($"Data: {Moment}");
            x.AppendLine($"Status: {Status}");
            
            return x.ToString();
        }
    }
}
