using Exercicio01.Services;
using System;
using System.Collections.Generic;
using System.IO;


namespace Exercicio01

{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Acesso> acessos = new HashSet<Acesso>();

            string path = @"C:\Users\Interfocus\Desktop\Breno\CursoC#-Exercicios\Conjuntos\teste.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        
                        string[] line = sr.ReadLine().Split(' ');
                        string nome = line[0];
                        DateTime hora = DateTime.Parse(line[1]);
                        acessos.Add(new Acesso(nome, hora));
                        
                    }
                    Console.WriteLine(acessos.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            

           
        }
    }
}


