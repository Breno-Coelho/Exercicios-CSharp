using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente a = new Cliente();
            Console.WriteLine("Digite o nome do Cliente: ");
            a.AlteraNome(Console.ReadLine());
            Console.WriteLine($"Digite a conta do Cliente {a.Nome}: ");
            a.AlteraConta(Console.ReadLine());
            Console.WriteLine("Haverá deposito inicial? (s/n)");
            string r = Console.ReadLine();
            if (r.ToUpper() == "S")
            {
                Console.WriteLine("Digite o valor do depósito Inicial: ");
                float dep = float.Parse(Console.ReadLine());
                a.Deposito(dep);
            }
            else
            {
                Console.WriteLine("Ok!");
            }
            Console.Clear();
            Console.WriteLine($"Dados da conta:\nNome: {a.Nome, -10} Conta: {a.Conta, -10} Saldo: {a.Saldo,-10:C}\n");
            Console.WriteLine("Digite um valor que será depositado: ");
            float d = float.Parse(Console.ReadLine());
            a.Deposito(d);
            Console.WriteLine($"Dados da conta:\nNome: {a.Nome,-10} Conta: {a.Conta,-10} Saldo: {a.Saldo,-10:C}\n");
            Console.WriteLine("Digite um valor que será sacado: ");
            d = float.Parse(Console.ReadLine());
            a.Saque(d);
            Console.WriteLine($"Dados da conta:\nNome: {a.Nome,-10} Conta: {a.Conta,-10} Saldo: {a.Saldo,-10:C}\n");

        }
    }
}
