using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a;
            a = new Funcionario();
            Console.WriteLine("Digite o Nome do funcionário: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário Bruto do funcionário: ");
            a.SalarioBruto = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do imposto pago: ");
            a.Imposto = float.Parse(Console.ReadLine());
            Console.WriteLine($"O Salário líquido do Funcionario {a.Nome} é {a.SalarioLiquido():C}");
            Console.WriteLine("Digite a porcentagem de aumento que será dada: ");
            float aumento = float.Parse(Console.ReadLine());
            a.Aumento(aumento);
            Console.WriteLine($"O novo salário líquido do funcionário {a.Nome} é {a.SalarioLiquido():C}");
        }
    }
}
