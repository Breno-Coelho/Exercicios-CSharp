using System;
using System.Linq;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 2, 4, 6, 7, 8, 9, 1, 32 };

            var mult = numeros.Where(x => x % 2 == 1).Select(x => x*10);

            foreach (var item in numeros)
            {
                Console.Write( item + ", ");
            }
            Console.WriteLine();
            foreach (var item in mult)
            {
                Console.Write(item + ", ");
            }

        }
    }
}
