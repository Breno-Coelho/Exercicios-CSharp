using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];
            Console.WriteLine("Digite o número de estudantes que serão hospedados: ");
            int estudantes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= estudantes; i++)
            {
                Console.WriteLine("Digite o número do quarto: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (quartos[numero] == null)
                {
                    Console.WriteLine($"Digite o nome do Estudante que ficará no quarto {numero}: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine($"Digite o e-mail do {nome}: ");
                    string email = Console.ReadLine();
                    quartos[numero] = new Quarto(nome, email, numero);
                }else
                {
                    while(true)
                    {
                        Console.WriteLine($"O quarto {numero} está ocupado, digite outro: ");
                        numero = int.Parse(Console.ReadLine());
                        if (quartos[numero] == null)
                        {
                            Console.WriteLine($"Digite o nome do Estudante que ficará no quarto {numero}: ");
                            string nome = Console.ReadLine();
                            Console.WriteLine($"Digite o e-mail do {nome}: ");
                            string email = Console.ReadLine();
                            quartos[numero] = new Quarto(nome, email, numero);
                            break;
                        }
                        
                    }
                }
            }
            for (int i=0; i <= 9; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"O quarto {i} está ocupado por {quartos[i].Estudante}\nEmail: {quartos[i].Email}");
                }
            }
        }
    }
}
