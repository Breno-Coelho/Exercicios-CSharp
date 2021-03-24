using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            float X, Y;

            Console.WriteLine($"Digite o valor de X e Y: ");
            string[] vet = Console.ReadLine().Split(' ');
            X = float.Parse(vet[0]);
            Y = float.Parse(vet[1]);
            if (X == 0 && Y != 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Eixo X");
            }
            else if (Y == 0 && X != 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Eixo Y");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Quadrante Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Quadrante Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Quadrante Q3");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem ao Quadrante Q4");
            }
            else {
                Console.WriteLine($"As coordenadas {X} e {Y} Correspondem a Origem");
            }
        }
    }
}
