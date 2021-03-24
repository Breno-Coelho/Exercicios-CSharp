using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor entre 0 e 1000: ");
            int x = int.Parse(Console.ReadLine());
            while (x > 1000 || x <= 0)
            {
                Console.WriteLine("Valor Invalido! Digite um número entre 0 e 1000:");
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Os números ímpares de 0 até {x} são:");
            for (int i = 1; i <= x; i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}
