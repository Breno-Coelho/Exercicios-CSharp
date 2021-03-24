using System;

namespace Exercicio05
{
    class Program
    {
        public static object geraMenu() 
        {
            Console.SetCursorPosition(10, 4);
            Console.WriteLine("Digite o código do item desejado:");
            Console.SetCursorPosition(10, 5);
            Console.WriteLine($"{"Código",-20} {"Descrição",-20} {"Preço",20}");
            Console.SetCursorPosition(10, 6);
            Console.WriteLine($"{"1",-20} {"Cachorro-quente",-20} {"R$ 4,00",20}");
            Console.SetCursorPosition(10, 7);
            Console.WriteLine($"{"2",-20} {"X-Salada",-20} {"R$ 4,50",20}");
            Console.SetCursorPosition(10, 8);
            Console.WriteLine($"{"3",-20} {"X-Bacon",-20} {"R$ 5,00",20}");
            Console.SetCursorPosition(10, 9);
            Console.WriteLine($"{"4",-20} {"Torrada Simples",-20} {"R$ 2,00",20}");
            Console.SetCursorPosition(10, 10);
            Console.WriteLine($"{"5",-20} {"Refrigerante",-20} {"R$ 1,50",20}");
            return null;
        }
        static void Main(string[] args)
        {
            int escolha, qtd;
            Console.WriteLine(geraMenu());
            Console.WriteLine("Digite o código do produto desejado: ");
            int.TryParse(Console.ReadLine(), out escolha);
            Console.WriteLine("Digite a quantidade: ");
            int.TryParse(Console.ReadLine(), out qtd);

            if (escolha == 1)
            {
                Console.WriteLine($"O valor do pedido foi de {(qtd * 4):C}");
            }
            else if (escolha == 2)
            {
                Console.WriteLine($"O valor do pedido foi de {(qtd * 4.5):C}");
            }
            else if (escolha == 3)
            {
                Console.WriteLine($"O valor do pedido foi de {(qtd * 5):C}");
            }
            else if (escolha == 4)
            {
                Console.WriteLine($"O valor do pedido foi de {(qtd * 2):C}");
            }
            else if (escolha == 5)
            {
                Console.WriteLine($"O valor do pedido foi de {(qtd * 1.5):C}");
            }
            else {
                Console.WriteLine("Opção inválida!");
            }

        }
    }
}
