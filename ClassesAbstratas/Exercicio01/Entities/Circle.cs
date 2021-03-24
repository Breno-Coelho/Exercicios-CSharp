using Exercicio01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Circle : Shape
    {
        public float Raio { get; set; }

        public Circle()
        {
        }

        public Circle(float raio, Color cor) : base(cor)
        {
            Raio = raio;
        }

        public override float Area()
        {
            return (float)3.14 * (Raio*Raio);
        }


        public override string ToString()
        {
            return $"Círculo - Cor: {Cor} - Area: {Area().ToString("2f")}";
        }
    }
}
