using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            int n;

            Console.WriteLine("Digite um número");
            int.TryParse(Console.ReadLine(), out n);
            if (n % 2 == 0)
            {
                Console.WriteLine($"O número {n} é par");
            }
            else {
                Console.WriteLine($"O número {n} é ímpar");
            }             
        }
    }
}
