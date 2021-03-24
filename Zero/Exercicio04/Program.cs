using System;

namespace Exercicio04
{
    class Program
    {
        public static float Pede(string x)
        {
            float retorno;
            Console.WriteLine($"Digite {x}: ");
            float.TryParse(Console.ReadLine(), out retorno);
            return retorno;
        }
        
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o código de uma peça 1, o número de peças 1,
             * o valor unitário de cada peça 1, o
             código de uma peça 2, o número de peças 2 e o valor unitário de cada 
            peça 2.Calcule e mostre o valor a ser pago.*/

            int codP1, codP2, quanP1, quanP2;
            float preP1, preP2;

            codP1 = (int)Pede("o código do produto 1");
            quanP1 = (int)Pede("a quantidade do produto 1");
            preP1 = Pede("o valor do produto 1");
            
            codP2 = (int)Pede("o código do produto 2");
            quanP2 = (int)Pede("a quantidade do produto 2");
            preP2 = Pede("o valor do produto 2");
            
            Console.WriteLine($"O Valor total do pedido é {(quanP1*preP1 + quanP2*preP2):C}");

        }
    }
}
