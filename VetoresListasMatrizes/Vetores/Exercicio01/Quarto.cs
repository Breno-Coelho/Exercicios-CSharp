using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Quarto
    {
        public string Estudante { get; private set; }
        public string Email { get; private set; }
        public int NumeroQuarto { get; private set; }

        public Quarto(string estudante, string email, int numeroQuarto)
        {
            Estudante = estudante;
            Email = email;
            NumeroQuarto = numeroQuarto;
        }
    }
}
