using Exercicio01.Entities;
using Exercicio01.Entities.Enums;
using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order pedido = new Order
            {
                Id = 01,
                Moment = DateTime.Now,
                Status = OrderStatus.PagamentoPendente,
            };
            Console.WriteLine(pedido);

            string texto = OrderStatus.PagamentoPendente.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Entregue");

            Console.WriteLine(texto);
            Console.WriteLine(os);
        }
    }
}
