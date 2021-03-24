using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string res;
            Dictionary<string, int> candidatos = new Dictionary<string, int>();
            while (true)
            {
                
                Console.WriteLine("Digite o nome e quantidade de votos do candidato: ");
                string[] cand = Console.ReadLine().Split(' ');
                string nome = cand[0];
                int votos = int.Parse(cand[1]);
                Console.WriteLine("Quer continuar? ");
                res = Console.ReadLine();
                if (res == "n")
                {
                    break;
                }
                if (candidatos.ContainsKey(nome))
                {
                    candidatos[nome] += votos;
                }
                else
                {
                    candidatos[nome] = votos;
                }

            }
            foreach (var item in candidatos)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
