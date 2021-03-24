using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            Console.WriteLine("Digite a senha: ");
            senha = Console.ReadLine();
            while (senha != "2002")
            {
                Console.WriteLine("Acesso Negado!");
                Console.WriteLine("Digite a senha novamente: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido!");
        }
    }
}
