using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    class Funcionario
    {
        public string Nome;
        public float SalarioBruto;
        public float Imposto;

        public float SalarioLiquido()
        {
            float c = SalarioBruto - Imposto;
            return c;
        }

        public void Aumento(float x)
        {
            SalarioBruto += (SalarioBruto * (x / 100));
        }
    }
}
