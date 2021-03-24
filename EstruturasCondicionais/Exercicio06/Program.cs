using System;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            float escolha;

            Console.WriteLine("Digite um valor qualquer: ");
            float.TryParse(Console.ReadLine(), out escolha);
            if (escolha >= 0 || escolha <= 25)
            {
                Console.WriteLine($"O valor {escolha} está no intervalo [0, 25]");
            }
            else if (escolha > 25 || escolha <= 50)
            {
                Console.WriteLine($"O valor {escolha} está no intervalo [25, 50]");
            }
            else if (escolha > 50 || escolha <= 75)
            {
                Console.WriteLine($"O valor {escolha} está no intervalo [50, 75]");
            }
            else if (escolha > 75 || escolha <= 100)
            {
                Console.WriteLine($"O valor {escolha} está no intervalo [25, 50]");
            }
            else {
                Console.WriteLine($"O valor {escolha} está fora do intervalo");
            }

        }
    }
}
