using System;

namespace Exercicio05
{
    class Program
    {
        public static float Pede(char x) {
            float retorno;
            Console.WriteLine($"Digite o valor de {x}");
            float.TryParse(Console.ReadLine(), out retorno);
            return retorno;
        }
        static void Main(string[] args)
        {
            /*Fazer um programa que leia três valores com ponto flutuante de dupla 
             * precisão: A, B e C.Em seguida, calcule mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/
            float A, B, C;

            A = Pede('A');
            B = Pede('B');
            C = Pede('C');
            //{X:F2}
            Console.WriteLine($"A área do triângulo é: {((A*C)/2).ToString("N2")}");
            Console.WriteLine($"A área do círculo é: {(Math.Pow(C, 2)*3.14159).ToString("N2")}");
            Console.WriteLine($"A área do trápezio é: {(((A+B)*C)/2).ToString("N2")}");
            Console.WriteLine($"A área do quadrado é: {(B*B).ToString("N2")}");
            Console.WriteLine($"A área do retângulo é: {(A*B).ToString("N2")}");

        }
    }
}
