using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            
            Console.WriteLine("Digite um valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os divisores de {x} são:");
            for (int i = 1; i <= x; i++)
            {
                if(x % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
