using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    class Aluno
    {
        public string Nome;
        public string[] Notas;

        public float Media()
        {
            return (float.Parse(Notas[0]) + float.Parse(Notas[1]) + float.Parse(Notas[2]));
        }

        public static void Teste()
        {
            Console.WriteLine("IHUUUU");
        }
        
    }
}
