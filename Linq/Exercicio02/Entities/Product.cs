using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }


        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Name}, Preço: {Price}, Categoria: {Category.Id}/{Category.Name}/{Category.Tier}".ToString();
        }

        public int CompareTo(object obj)
        {
            Product outro = obj as Product;
            return Price.CompareTo(outro.Price);
        }



    }
}
