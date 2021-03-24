using System;

namespace Exercicio04
{
    class Program
    {
        static string [] Pede(int x)
        {
            Console.WriteLine($"Digite o divisor e o dividendo da divisão {x}");
            string[] vet = Console.ReadLine().Split(' ');
            return vet;
        }
        static void Main(string[] args)
        {
            string[] vet;
            float a, b;
            Console.WriteLine("Digite o número de divisões que serão feitas: ");
            int divi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= divi; i++)
            {
                vet = Pede(i);
                a = float.Parse(vet[0]);
                b = float.Parse(vet[1]);
                if (b == 0) {
                    Console.WriteLine("Divisão impossível!!!");
                }
                else
                {
                    Console.WriteLine($"O resultado de {a} dividido por {b} é: {a/b}");
                }
            }
        }
    }
}
