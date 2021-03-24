using System;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            float renda, baseImposto, imposto;
            Console.WriteLine("Digite sua renda: ");
            float.TryParse(Console.ReadLine(), out renda);
            if (renda <= 2000) {
                Console.WriteLine($"A renda {renda:C} é isenta de impostos");
            }
            else if (renda > 2000 && renda <= 3000)
            {
                baseImposto = renda - 2000;
                Console.WriteLine($"O valor pago de imposto será {(baseImposto * 0.08):C}");
            }
            else if (renda > 3000 && renda <= 4500) {
                baseImposto = renda - 3000;
                imposto = 1000 * 0.08f;
                imposto += baseImposto * 0.18f;
                Console.WriteLine($"O valor pago de imposto será {imposto:C}");
            }
            else {
                baseImposto = renda - 4500;
                imposto = (1000 * 0.08f) + (1500 * 0.18f) + (baseImposto * 0.28f);
                Console.WriteLine($"O valor pago de imposto será {imposto:C}");
            }

        }
    }
}
