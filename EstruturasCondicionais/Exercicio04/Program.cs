using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia a hora inicial e a hora final de um jogo. 
             * A seguir calcule a duração do jogo, sabendo que o mesmo pode
            começar em um dia e terminar em outro, tendo uma duração 
            mínima de 1 hora e máxima de 24 horas.*/
            int i, f;

            Console.WriteLine("Digite a hora inicial e final do jogo:");
            string[] vet = Console.ReadLine().Split(' ');
            i = int.Parse(vet[0]);
            f = int.Parse(vet[1]);


            if (i < f)
            {
                Console.WriteLine($"O jogo durou {f - i} horas");
            }
            else {
                Console.WriteLine($"O jogo durou {24 - i + f} horas");
            }
        }
    }
}
