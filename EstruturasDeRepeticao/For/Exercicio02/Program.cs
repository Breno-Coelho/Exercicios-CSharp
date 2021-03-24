using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd, d = 0, f = 0;
            Console.WriteLine("Informe a quantidade de valores que serão lidos: ");
            qtd = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Digite um número: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    d++;
                }
                else
                {
                    f++;
                }
            }
            Console.WriteLine($"Aqui estão os resultados:\n{d} Dentro do intervalo;\n{f} Fora do intervalo. ");
        }
    }
}
