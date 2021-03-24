using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a;
            a = new Aluno();
            Console.WriteLine("Digite o nome do aluno");
            a.Nome = Console.ReadLine();
            Console.WriteLine($"Digite as notas do aluno {a.Nome}: ");
            a.Notas = Console.ReadLine().Split(' ');
            Console.WriteLine($"A média foi de {a.Media()}");
            if (a.Media() < 60)
            {
                Console.WriteLine($"O aluno {a.Nome} foi reprovado por falta de {(a.Media()-60)*-1} pontos");
            }
            else
            {
                Console.WriteLine($"Aprovado!");
            }
            Aluno.Teste();
        }
    }
}
