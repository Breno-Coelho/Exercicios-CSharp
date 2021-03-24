using System;
using System.Collections.Generic;


namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Digite o número de fúncionarios que serão cadastrados: ");
            int fun = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fun; i++)
            {
                Console.WriteLine($"##Funcionário {i}##");
                Console.Write("Digite o ID: ");
                int id = int.Parse(Console.ReadLine());
                bool cond = true;
                //Funcionario sla = funcionarios.Find(x => x.Id == id); Eu não sabia que tinha que declara a variavel com o tipo da classe ushaudhsauhduas
                foreach (Funcionario x in funcionarios)
                {
                    if (x.Id == id)
                    {
                        Console.WriteLine("Já existe um usuário com este ID!");
                        i--;
                        cond = false;
                        break;
                    }
                }
                if (cond)
                {
                    Console.WriteLine($"Digite o nome do Funcionário {id}:");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Digite o Salario do {nome}");
                    float salario = float.Parse(Console.ReadLine());
                    Funcionario f = new Funcionario(nome, id, salario);
                    funcionarios.Add(f);
                }
            }
            while (true)
            {
                Console.WriteLine("Digite o Id do funcionário que receberá o aumento: ");
                int au = int.Parse(Console.ReadLine());
                bool cond = true;
                foreach (var x in funcionarios)
                {
                    if (x.Id == au)
                    {
                        cond = false;
                        Console.WriteLine($"Digite a porcentagem do aumento do funcionário {au}: ");
                        float p = float.Parse(Console.ReadLine());
                        x.Aumenta(p);

                    }
                }
                if (cond)
                {
                    Console.WriteLine("O funcionário não foi encontrado");
                }
                else
                {
                    Console.WriteLine("Esses são os funcionários e seus salários: ");
                    foreach (var item in funcionarios)
                    {
                        Console.WriteLine($"ID: {item.Id};\nNome: {item.Nome};\nSalário: {item.Salario:C}");
                    }
                    break;
                }
            }
        }
    }
}
