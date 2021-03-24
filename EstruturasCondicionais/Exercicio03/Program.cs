using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar 
            uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. 
            Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.*/

            int A, B;

            Console.WriteLine("Digite o valor de A e B: ");
            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine($"Os números {A} e {B} são multíplos.");
                
            }
            else
            {
                Console.WriteLine($"Os números {A} e {B} não são multíplos.");
            }







            }
        }
    }
