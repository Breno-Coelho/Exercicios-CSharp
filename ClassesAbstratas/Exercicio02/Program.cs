using Exercicio02.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            float total = 0;
            List<TaxPayer> contribuintes = new List<TaxPayer>();

            Console.WriteLine("Digite o número de contribuintes: ");
            c = int.Parse(Console.ReadLine());

            for (int i = 1; i <= c; i++)
            {
                string tipo;

                Console.WriteLine($"---------------Contribuinte {i}---------------");
                Console.WriteLine("Digite se é PF ou PJ: ");
                tipo = Console.ReadLine();
                if (tipo.ToUpper() == "PF")
                {
                    string nome;
                    float anual, med;
                    
                    Console.WriteLine("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite os ganhos anuais: ");
                    anual = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite as despesas médicas: ");
                    med = float.Parse(Console.ReadLine());
                    TaxPayer n = new Individual(med, nome, anual);
                    contribuintes.Add(n);
                }
                else
                {
                    string nome;
                    float anual;
                    int fun;

                    Console.WriteLine("Digite o nome da empresa: ");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite os ganhos anuais: ");
                    anual = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de funcionários: ");
                    fun = int.Parse(Console.ReadLine());
                    TaxPayer n = new Company(fun,nome, anual);
                    contribuintes.Add(n);
                }
            }

            Console.WriteLine("----------------Impostos pagos---------------");

            foreach (TaxPayer item in contribuintes)
            {
                Console.WriteLine($"{item.Name} - {item.Tax():C}");
                Console.WriteLine("----------------------------------");
                total += item.Tax();
            }

            Console.WriteLine($"Total pago - {total:C}");
        }
    }
}
