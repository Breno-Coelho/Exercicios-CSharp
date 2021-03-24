using System;

namespace EstruturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.*/
            int numero;

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out numero);
            if (numero > 0)
            {
                Console.WriteLine($"O valor {numero} é positivo");
            }
            else if (numero < 0) { 
                Console.WriteLine($"O valor {numero} é negativo");
            }
            else
            {
                Console.WriteLine($"O valor {numero} é nulo");
            }
            
        }
    }
}
