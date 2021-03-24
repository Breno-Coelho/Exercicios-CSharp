using Exercicio01.Entities;
using Exercicio01.Entities.Exceptions;
using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite o número da conta: ");
                int conta = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome do Propreitário da conta: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o saldo: ");
                float saldo = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Limite de saque: ");
                float limit = float.Parse(Console.ReadLine());
                Account a = new Account(conta, nome, saldo, limit);
                Console.WriteLine("Digite o valor do saque: ");
                float saque = float.Parse(Console.ReadLine());
                a.Saque(saque);
            }
            catch (Exception x)
            {
                Console.WriteLine($"Houve um erro " + x.Message);
            }
        }
    }
}
