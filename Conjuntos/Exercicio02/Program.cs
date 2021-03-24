using Exercicio02.Entitites;
using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Curso> alunos = new HashSet<Curso>();
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"quantoa alunos existem no curso {i+1}?");
                int a = int.Parse(Console.ReadLine());
                for (int j = 0;  j < a;  j++)
                {
                    Console.WriteLine($"Digite o Aluno {j+1}");
                    int aluno = int.Parse(Console.ReadLine());
                    alunos.Add(new Curso(aluno));
                }
            }
            Console.WriteLine(alunos.Count);
        }
    }
}
