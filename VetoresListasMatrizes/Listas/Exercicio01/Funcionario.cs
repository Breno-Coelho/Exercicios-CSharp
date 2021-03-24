using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public float Salario { get; private set; }

        public Funcionario(string Nome, int Id, float Salario)
        {
            this.Nome = Nome;
            this.Id = Id;
            this.Salario = Salario;
        }

        public void Aumenta(float x) {
            Salario += (Salario * (x / 100));
           
        }

    }
}
