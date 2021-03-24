using Exercicio04.Entities;
using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Post a = new Post(DateTime.Now, "TESTEEEEEE", "Que teste mais doido", 44);
            Post b = new Post(DateTime.Now, "TESTADOOOO", "Que teste mais teste", 99);


            Comments x = new Comments("KKKFODA-SE???");
            a.AddComment(x);
            Console.WriteLine(b);
            Console.WriteLine(a);

        
        }
    }
}
