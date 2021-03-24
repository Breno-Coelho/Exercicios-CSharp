using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, fat;
            Console.WriteLine("Digite um valor: ");
            n = int.Parse(Console.ReadLine());
            if (n == 0){
                Console.WriteLine("Por definição, o fatorial de 0 é 1");
            }
            fat = n;
            for (int i = 1; i < n; i++)
            {
                fat *= (n-i);
            }
            Console.WriteLine($"O fatorial de {n} é {fat}");
        }
    }
}
