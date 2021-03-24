using System;
using System.IO;
using System.Linq;
using System.Globalization;
using Exercicio04.Entitites;
using System.Collections.Generic;


namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\Interfocus\Desktop\Breno\CursoC#-Exercicios\Linq\Exercicio04\exercicio.txt";
            List<Employee> funcionarios = new List<Employee>();
            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(',');
                    string nome = vet[0];
                    string email = vet[1];
                    double salario = double.Parse(vet[2], CultureInfo.InvariantCulture);
                    funcionarios.Add(new Employee(nome, email, salario));
                }
            }

            foreach (var item in funcionarios)
            {
                Console.WriteLine(item);
            }
            Console.Write("Digite o valor dos salarios que gostaria de filtrar");
            double fs = double.Parse(Console.ReadLine());
            var salarioSuperior = funcionarios.Where(x => x.Salary > fs).OrderBy(x => x.Email).Select(x => x.Email);
            Console.WriteLine($"Lista dos E-mails dos funcionários que recebem mais de {fs:C}: ");
            foreach (var item in salarioSuperior)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------Funcionários que começam com a letra M----------------------");
            var somaSalM = funcionarios.Where(x => x.Name.StartsWith("M")).Sum(x => x.Salary);//Esse aqui vai direto e reto
            var comecaM = funcionarios.Where(x => x.Name.StartsWith("M"));
            foreach (var item in comecaM)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("A soma desses salários é: " + comecaM.Sum(x => x.Salary).ToString("F2"));

        
        }
    }
}
