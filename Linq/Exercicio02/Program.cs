using Exercicio02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var resultado1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900);
            var resultado2 = products.Where(x => x.Category == c1).Select(x => x.Name);
            var resultado3 = products.Where(x => x.Name.ToLower().StartsWith("c"));
            var resultado4 = products.Where(x => x.Category.Tier == 1).OrderByDescending(x => x.Price).ThenByDescending(x => x.Name);
            var resultado5 = resultado4.Skip(3).Take(2);
            var resultado6 = products.Last();
            var resultado7 = products.FirstOrDefault();
            var resultado8 = products.Where(x => x.Id == 3).SingleOrDefault();//traz só um resultado, se tiver mais dá pau;
            var resultado9 = products.Max(); //se não passar nenhuma expressão vai precisar implementar o IComparable na classe;
            var resultado10 = products.Min();
            var resultado11 = products.Where(x => x.Category.Tier == 8).Sum(x => x.Price);
            var resultado12 = products.Where(x => x.Category.Tier == 1).Average(x => x.Price);//Se a coleção estiver vazia a media dá erro;
            var resultado13 = products.Where(x => x.Category.Tier == 8).Select(x => x.Price).DefaultIfEmpty(0).Average(); //Essa é uma medida protetiva para caso a coleção venha vazia, será posto o valor 0, e a media de um item com o valor 0 é 0
            var resultado14 = products.Where(x => x.Category.Tier == 1).Select(x => x.Price).Aggregate((x, y) => x + y); //Se a coleção estiver vazia a media dá erro;
            var resultado15 = products.Where(x => x.Category.Tier == 8).Select(x => x.Price).Aggregate(0.0,(x, y) => x + y);  //Essa é uma medida protetiva para caso a coleção venha vazia
            var resultado16 = products.GroupBy(x => x.Category); // Pra exibir esse resultado vai precisar usar o IGrouping, que transrforma em um conjunto de chave-valor

            
            foreach (IGrouping<Category, Product> agrupamento in resultado16)//IGrouping<O Parâmetro do agrupamento, tipo que está sendo agrupado(no caso é um agrupamento de produtos baseado em suas categorias)>
            {
                foreach (Product item in agrupamento)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
