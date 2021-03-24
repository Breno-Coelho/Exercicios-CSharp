using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor a ser comprado: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do dólar: ");
            float d = float.Parse(Console.ReadLine());

            Console.WriteLine($"O custo de {d} dólares será {Conversor.Converte(r, d):C}");
        }
    }
}
