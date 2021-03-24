using Exercicio01.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont_f;
            List<Employee> funcionarios = new List<Employee>();

            Console.WriteLine("Digite quantos funcionários serão adicionados: ");
            cont_f = int.Parse(Console.ReadLine());
            for (int i = 1; i <= cont_f; i++)
            {
                string ter, nome;
                int horas;
                float valorHora, extra; 

                Console.WriteLine($"-------------Funcionário{i}-------------");
                Console.Write("Este funcionário é terceirizado?(s/n) ");
                ter = Console.ReadLine();
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine($"Digite as horas trabalhadas do funcionário {nome}: ");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o valor das horas trabalhadas do funcionário {nome}: ");
                valorHora = float.Parse(Console.ReadLine());
                if (ter.ToUpper() == "S")
                {
                    Console.WriteLine($"Digite o valor do extra do funcionário {nome}: ");
                    extra = float.Parse(Console.ReadLine());
                    Employee f = new OutsourcedEmployee(nome, horas, valorHora, extra);
                    funcionarios.Add(f);
                }
                else
                {
                    Employee f = new Employee(nome, horas, valorHora);
                    funcionarios.Add(f);
                }
                

            }
            Console.WriteLine("--------------Pagamentos-------------");
            foreach (var x in funcionarios)
            {
                Console.WriteLine($"{x.Name} - {x.Payment():c}");
                Console.WriteLine("----------------------------------");
            }
        }
    }
}
