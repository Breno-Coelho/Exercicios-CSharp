using Exercicio01.Entities;

using Exercicio01.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            List<Shape> figuras = new List<Shape>();
            
            Console.WriteLine("Digite o número de figuras: ");
            f = int.Parse(Console.ReadLine());
            for (int i = 1; i <= f; i++)
            {
                string tipo;
                
                Console.WriteLine($"---------------------Figura {i}------------------");
                Console.Write("Digite a cor(Black/Blue/Red): ");

                Color cor = Enum.Parse<Color>(Console.ReadLine());
                Console.Write("Retangulo ou círculo?(c/r)");
                tipo = Console.ReadLine();
                switch (tipo.ToLower())
                {
                    case "c":
                        Console.Write("Digite o raio do Círculo: ");
                        float raio = float.Parse(Console.ReadLine());
                        Circle c = new Circle(raio, cor);
                        figuras.Add(c);
                        break;
                    case "r":
                        Console.Write("Digite a altura e largura: ");
                        string[] vet = Console.ReadLine().Split(" ");
                        float alt = float.Parse(vet[0]);
                        float lar = float.Parse(vet[1]);
                        Rectangle r = new Rectangle(alt, lar, cor);
                        figuras.Add(r);
                        break;
                    default:
                        Console.WriteLine("XXXXXXXXXXXXXXXXXXXX");
                        break;
                }
            }
            Console.WriteLine("------------AREAS---------");
            foreach (Shape item in figuras)
            {
                Console.WriteLine(item);
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
