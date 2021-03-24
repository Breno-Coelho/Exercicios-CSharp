using Exercicio02.Entities;
using Exercicio02.Entities.Enums;
using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as informações do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Digite a data de nascimento: ");
            DateTime nasc = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Insira o Status do pedidio: ");
            OrderStatus s = Enum.Parse<OrderStatus>(Console.ReadLine());
            Client cliente = new Client(nome, email, nasc);
            Console.Write("Quantos itens haverão no pedido? ");
            int pedidos = int.Parse(Console.ReadLine());
            Order Pedido = new Order(DateTime.Now, s);
            for (int i = 1; i <= pedidos; i++)
            {
                Console.WriteLine($"----------------PEDIDO #{i}----------------");
                Console.WriteLine("Digite o nome do produto: ");
                string NomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o preço: ");
                float PrecoProduto = float.Parse(Console.ReadLine());
                Product produto = new Product(NomeProduto, PrecoProduto);
                Console.WriteLine("Informe a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                OrderItem ItemPedido = new OrderItem(quantidade, PrecoProduto);
                Pedido.Items.Add(ItemPedido);

            }
            Console.WriteLine(Pedido);
            Console.WriteLine($"Cliente: {cliente.Name} ({cliente.BirthDate}) - {cliente.Email}");
            Console.WriteLine("Itens do pedido: ");
            foreach (OrderItem i in Pedido.Items)
            {
                Console.WriteLine($"Item: {i.Product}, Preço: {i.Price:C}, Quantidade: {i.Quantiy}, Subtotal: {i.SubTotal()}");
            }
            Console.WriteLine($"Total: {Pedido.Total()}");

        }
    }
}
