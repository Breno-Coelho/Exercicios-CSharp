using System;

namespace Exercicio03
{
    class Program
    {
        static string[] Pede(int x)
        {
            Console.WriteLine($"Digite as notas do aluno {x}");
            string[] vet = Console.ReadLine().Split(' ');
            return vet;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de notas que serão lidas: ");
            int notas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= notas; i++)
            {
                string[] NotasAluno = Pede(i);
                float media = 0;
                media = (float.Parse(NotasAluno[0]) * 0.2f) + (float.Parse(NotasAluno[1]) * 0.3f) + (float.Parse(NotasAluno[2]) * 0.5f);
                Console.WriteLine($"A média do aluno {i} é {media.ToString("F2")}");
            }
        }
    }
}
