using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo a;
            Console.WriteLine("Digite a Largura e Altura de um Retângulo: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = new Triangulo();
            a.Largura = float.Parse(vet[0]);
            a.Altura = float.Parse(vet[1]);
            Console.WriteLine($"A área do retângulo é: {a.Area(a.Largura, a.Altura)}\n O perimetro do retângulo é: {a.Perimetro(a.Largura, a.Altura)}\nA diagonal do retângulo é {a.Diagonal(a.Largura, a.Altura)}");
        }
    }
}
