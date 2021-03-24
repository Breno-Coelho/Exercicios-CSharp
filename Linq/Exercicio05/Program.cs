using Exercicio05.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>() {
                new Pessoa("Thiago Nicolas Barbosa", "thiago@hotmail.com", "12345699874", 13),
                new Pessoa("Marcos Vinicius Henry Viana","marcos86@gmail.com","18445699874", 32),
                new Pessoa("Mariane Giovana","mariane@gmail.com","27445699874", 29),
                new Pessoa("Filipe Ryan Cauã Viana","filipe@hotmail.com","19985699874", 20),
                new Pessoa("Tatiane Bianca Lara da Cunha","tati@gmail.com","42985690174", 40),
                new Pessoa("Maria Sandra","sandrama@hotmail.com","45289690174", 40),
            };
            Console.WriteLine("----------------Pessoas cadastradas-------------------");
            foreach (var item in pessoas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------------------------\n");
            Console.Write("Digite a inicial que gostaria de filtrar: ");
            //nome
            string fn = Console.ReadLine();
            var filtroNome = pessoas.Where(x => x.Nome.StartsWith(fn.ToUpper()));
            if (filtroNome.Count() == 0)
            {
                Console.WriteLine("Não foi encontrada nenhuma pessoa com essa inicial.");
            }
            else
            {
                Console.WriteLine($"Pessoas com a inicial {fn}:");
                foreach (var item in filtroNome)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.WriteLine("\n\n");
            //
            var pessoasMaiores = pessoas.Where(x => x.Idade > 17);
            var ordemAlfabetica = pessoas.OrderBy(x => x.Nome);
            var dominio = ordemAlfabetica.GroupBy(x => x.Email.Substring(x.Email.IndexOf("@")));
            var dominioMaiores = pessoasMaiores.GroupBy(x => x.Email.Substring(x.Email.IndexOf("@")));
            Console.WriteLine("Pessoas Agrupadas por dominio:");
            
            foreach (IGrouping<string, Pessoa> item in dominio)
            {
                Console.WriteLine("---->" + item.Key);
                var ordenado = item.OrderBy(x => x.Nome);
                foreach (var i in ordenado)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("------------------------------------------------------------");
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Pessoas Ordenadas por dominio e maiores de idade: " );
            foreach (IGrouping<string, Pessoa> item in dominioMaiores)
            {
                Console.WriteLine("---->" + item.Key);
                var ordenado = item.OrderBy(x => x.Nome);
                foreach (var i in ordenado)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("------------------------------------------------------------");
            }
        }
    }
}
