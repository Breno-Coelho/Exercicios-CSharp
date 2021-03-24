using Exercicio03.Entities;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo: ");
            string caminho = @"C:\Users\Interfocus\Desktop\Breno\CursoC#-Exercicios\Linq\Exercicio03\teste.txt";
            List<Product> produtos = new List<Product>();
            using (StreamReader sr = File.OpenText(caminho))
            {
                while (!sr.EndOfStream)
                {
                    string[] vet = sr.ReadLine().Split(",");
                    string nome = vet[0];
                    double preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
                    Console.WriteLine(preco);
                    produtos.Add(new Product(nome, preco));

                }
            }
            var mediaAlternativa = produtos.Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("A Média dos preços é: " + produtos.Average(x => x.Price).ToString("F2", CultureInfo.InvariantCulture));
            var nomesAbaixo = produtos.Where(x => x.Price < mediaAlternativa).OrderByDescending(x => x.Name).Select(x => x.Name);
            foreach (var item in nomesAbaixo)
            {
                Console.WriteLine(item);
            }

        }
    }
}
