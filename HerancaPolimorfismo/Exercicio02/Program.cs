using Exercicio02.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {
        static string[] Padrao()
        {
            string[] vet = new string[2];

            Console.WriteLine("Digite o nome do produto: ");
            vet[0] = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto: ");
            vet[1] = Console.ReadLine();
            return vet;
        }
        static void Main(string[] args)
        {
            int pro;
            List<Product> produtos = new List<Product>();

            Console.WriteLine("Informe o numero de produtos: ");
            pro = int.Parse(Console.ReadLine());
            for (int i = 1; i <= pro; i++)
            {
                string es, nome;
                float preco, taxa;
                DateTime data;
                Product p;
                string[] vet = new string[2];

                Console.WriteLine($"------------------Profuto {i}------------------");
                Console.WriteLine("Digite o estado do produto(c/u/i): ");
                es = Console.ReadLine();
                switch (es)
                {
                    case "c":
                        vet = Padrao();
                        nome = vet[0];
                        preco = float.Parse(vet[1]);

                        p = new Product(nome, preco);
                        produtos.Add(p);
                        break;
                    case "u":
                        vet = Padrao();
                        nome = vet[0];
                        preco = float.Parse(vet[1]);

                        Console.WriteLine("Digite a data do produto: ");
                        data = DateTime.Parse(Console.ReadLine());
                        p = new UsedProduct(nome, preco, data);
                        produtos.Add(p);
                        break;
                    case "i":
                        vet = Padrao();
                        nome = vet[0];
                        preco = float.Parse(vet[1]);

                        Console.WriteLine("Digite a taxa do produto: ");
                        taxa = float.Parse(Console.ReadLine());
                        p = new ImportedProduct(nome, preco, taxa);
                        produtos.Add(p);
                        break;
                    default:
                        Console.WriteLine("XXXXXXXX");
                        break;
                }


                foreach (var x in produtos)
                {
                    Console.WriteLine(x.priceTag());
                }
            }
        }
    }
}
