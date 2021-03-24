using System;

namespace Exercicio03
{
    class Program
    {
        static int Pede() {
            Console.WriteLine($"Digite a opção desejada: \n1- Alcool;\n2- Gasolina;\n3- Diesel;\n4- Fim.");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            int escolha = Pede(), ca = 0, cg = 0, cd = 0;
            while(escolha != 4)
            {
                if (escolha == 1)
                {
                    ca++;
                }
                else if (escolha == 2)
                {
                    cg++;
                }
                else if (escolha == 3)
                {
                    cd++;
                }
                else {
                    Console.WriteLine($"A opção {escolha} não existe.");
                }
                escolha = Pede();
            }
            Console.WriteLine($"Muito Obrigado! Aqui estão os resultados:\n1- Alcool: {ca};\n2- Gasolina: {cg};\n3- Diesel: {cd};");
        }
    }
}
