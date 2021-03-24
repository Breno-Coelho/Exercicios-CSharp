using System;

namespace Exercicio07v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a;
            
            Console.WriteLine("Digite o nome do Cliente: ");
            string n = Console.ReadLine();
            Console.WriteLine($"Digite a conta do Cliente {n}: ");
            string c = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (s/n)");
            string r = Console.ReadLine();
            if (r.ToUpper() == "S")
            {
                Console.WriteLine("Digite o valor do depósito Inicial: ");
                float dep = float.Parse(Console.ReadLine());
                a = new Cliente(n, c, dep);
            }
            else
            {
                Console.WriteLine("Ok!");
                a = new Cliente(n, c);
            }

            Console.WriteLine(a.ToString());
            Console.Write(" Digite um valor que será depositado: ");
            float d = float.Parse(Console.ReadLine());
            a.Deposito(d);
            Console.WriteLine(a.ToString());
            Console.Write(" Digite um valor que será sacado: ");
            d = float.Parse(Console.ReadLine());
            a.Saque(d);
            Console.WriteLine(a.ToString());
        }
        
        
    }
}
