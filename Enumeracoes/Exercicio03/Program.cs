using Exercicio03.Entities;
using System.Globalization;
using Exercicio03.Entities.Enums;
using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float salarioBase;
            Console.WriteLine("Informe o departamento: ");
            Departament dep = new Departament(Console.ReadLine());
            Console.WriteLine("Digite o nome do Funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário Base: ");
            salarioBase = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nívle do funcionário(Junior/MidLevel/Senior)");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Worker funcionario = new Worker(nome, nivel, salarioBase, dep);

            Console.Write("Informe quantos contratos serão adicionados: ");
            int i = int.Parse(Console.ReadLine());

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"---------------Contrato {j+1}-----------------");
                Console.WriteLine("Digite a data deste contrato: ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da hora: ");
                float ValorHora = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite as horas: ");
                int horas = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(data, ValorHora, horas);
                funcionario.Contracts.Add(contrato);

            }

            Console.WriteLine("Digite o mês e o ano que quer calcular: ");
            string dataConsulta = Console.ReadLine();
            int mes = int.Parse(dataConsulta.Substring(0,2));
            int ano = int.Parse(dataConsulta.Substring(3));

            Console.WriteLine($"Nome: {funcionario.Name}");
            Console.WriteLine($"Departamento: {funcionario.Departament.Name}");
            Console.WriteLine($"Salario: {funcionario.Income(ano, mes)}");

        }
    }
}
