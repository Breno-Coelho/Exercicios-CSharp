using System;

namespace Exercicio01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"{p1.Nome} é mais velho que {p2.Nome}");
            }
            else if (p1.Idade < p2.Idade)
            {
                Console.WriteLine($"{p2.Nome} é mais velho que {p1.Nome}");
            }else
            {
                Console.WriteLine("As idades são iguais");
            }
        }
    }
}
