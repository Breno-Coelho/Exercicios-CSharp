using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto a, b;
            a = new Produto();
            b = new Produto();

            Console.WriteLine("Digite as informações do produto A: ");
            string[] vet = Console.ReadLine().Split(' ');

            a.Nome = vet[0];
            a.Preco = float.Parse(vet[1]);
            a.Quantidade = int.Parse(vet[2]);

            Console.WriteLine("Digite as informações do produto B: ");
            vet = Console.ReadLine().Split(' ');

            b.Nome = vet[0];
            b.Preco = float.Parse(vet[1]);
            b.Quantidade = int.Parse(vet[2]);

            while (true)
            {
                Console.WriteLine($"Digite o nome do Produto que deseja utilizar:\n1-{a.Nome};\n2-{b.Nome} ");
                string produto = Console.ReadLine();


                if (produto == "1")
                {
                    OpcoesProduto(a);
                }
                else if (produto == "2")
                {
                    OpcoesProduto(b);
                }
                else
                {
                    Console.WriteLine("Produto não cadastrado!");
                    break;
                }


            }

            void OpcoesProduto(Produto x)
            {
                while (true)
                {
                    Console.WriteLine("Digite a opção desejada:\n1-Listar a quantidade;\n2-Listar o Valor total;\n3-Adicionar produto;\n4-Remover produto;\n5-Sair.");
                    string e = Console.ReadLine();
                    if (e == "1")
                    {
                        Console.WriteLine($"A quantidade em estoque do produto A é {x.Quantidade}");
                    }
                    else if (e == "2")
                    {
                        Console.WriteLine($"O preço do produto A é {x.Total()}");
                    }
                    else if (e == "3")
                    {
                        Console.WriteLine($"Digite a quantidade que irá adicionar: ");
                        int y = int.Parse(Console.ReadLine());
                        x.AddProdutos(y);
                        Console.WriteLine($"A quantidade do produto A agora é {x.Quantidade}");
                    }
                    else if (e == "4")
                    {
                        Console.WriteLine($"Digite a quantidade que irá remover: ");
                        int y = int.Parse(Console.ReadLine());
                        x.RemoveProdutos(y);
                        Console.WriteLine($"A quantidade do produto A agora é {x.Quantidade}");
                    }
                    else
                    {
                        Console.WriteLine("Fim!");
                        break;
                    }
                }
            }
        }
    }
}
