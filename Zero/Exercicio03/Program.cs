using System;
using System.Globalization;

namespace Exercicio03
{
    public class Program
    {
        public float Pede(string x) {
            float retorno;
            Console.WriteLine($"Digite o {x}: ");
            float.TryParse(Console.ReadLine(), out retorno);
            return retorno;
        }
        static void Main(string[] args)
        {
            /*Fazer um programa que leia o número de um funcionário, seu número de 
             * horas trabalhadas, o valor que recebe por
            hora e calcula o salário desse funcionário.A seguir, mostre o número 
            e o salário do funcionário, com duas casas
            decimais.*/
            int funcionario, horas;
            float salario, valorHora;

            funcionario = (int)Pede("número do funcionário");
            horas = (int)Pede("número de horas trabalhadas");
            valorHora = Pede("valor da hora");
            salario = valorHora * horas;
            
            Console.WriteLine($"O salário do funcionário {funcionario} é {salario :C}");
            
        }
    }
}
