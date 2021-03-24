using System;

namespace Exercicio02
{
    
    class Program
    {
        static string[]  PedeCoordenada()
        {
           Console.WriteLine("Digite o valor de X e Y: ");
           string[] vet = Console.ReadLine().Split(' ');
           return vet;
        }
        static void Main(string[] args)
        {
            float X, Y;
            string[] vet;

            vet = PedeCoordenada();
            X = float.Parse(vet[0]);
            Y = float.Parse(vet[1]);
            while (X != 0 || Y != 0) {
                if (X > 0 && Y > 0)
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

                vet = PedeCoordenada();
                X = float.Parse(vet[0]);
                Y = float.Parse(vet[1]);

            }
        }
    }
}
