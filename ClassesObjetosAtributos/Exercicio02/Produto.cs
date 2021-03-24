using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class Produto
    {
        public string Nome;
        public float Preco;
        public int Quantidade;

        public float Total()
        {
            return Preco * Quantidade;
        }

        public void AddProdutos(int x)
        {
            Quantidade += x;
        }

        public void RemoveProdutos(int x)
        {
            Quantidade -= x;
        }

        public void OpcoesProduto(string e, Produto x)
        {
            while (true) {
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
