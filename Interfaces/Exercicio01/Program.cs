using Exercicio01.Entities;
using Exercicio01.Services;
using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Installment> parcelas = new List<Installment>();

            Console.WriteLine("Digite o número do contrato: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do contrato");
            float total = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de parcelas: ");
            int par = int.Parse(Console.ReadLine());

            Contract contrato = new Contract(numero, data, total);
            PayPalService p = new PayPalService();
            ContractService a = new ContractService(p);
            a.ProcessContract(contrato, par);
            Console.WriteLine("--------------------Parcelas---------------------");
            Console.WriteLine(contrato.Installments.Count);
            foreach (Installment x in contrato.Installments)
            {
                Console.WriteLine($"{x.DueDate} - {x.Amount:c}");
            }
        }
    }
}
