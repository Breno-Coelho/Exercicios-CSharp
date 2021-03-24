using System;

namespace Exercicio02
{
    class Program
    {
        private static int PedeNumero(char x)
        {
            int resultado;
            Console.WriteLine($"Digite o valor de {x}: ");
            int.TryParse(Console.ReadLine(), out resultado);
            return resultado;
        }
        static void Main(string[] args)
        {
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir,
             calcule e mostre a diferença do produto de A e B
             pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
            int A, B, C, D, diferenca;

            A = PedeNumero('A');
            B = PedeNumero('B');
            C = PedeNumero('C');
            D = PedeNumero('D');
            diferenca = (A * B - C * D);
            Console.WriteLine($"A diferença entre {A} * {B} e {C} * {D} é {diferenca}");
        }
    }
}
