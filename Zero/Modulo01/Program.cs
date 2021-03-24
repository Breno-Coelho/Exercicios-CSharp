using System;

namespace Modulo01
{
    class Program
    {
        private const double p = 3.14159;
        static void Main(string[] args)
        {
            /*Faça um programa para ler o valor do raio de um círculo, 
             * e depois mostrar o valor da área deste círculo com quatro
              casas decimais conforme exemplos.
              Fórmula da área: area = π.raio2
              Considere o valor de π = 3.14159*/
            float raio;
            double area;
            Console.Write("Digite o raio do círculo: ");
            float.TryParse(Console.ReadLine(), out raio);
            area = p * (Math.Pow(raio, 2));
            Console.WriteLine($"A aréa do círculo é de aproximadamente {area}");


        }
    }
}
