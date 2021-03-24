using Exercicio01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01.Entities
{
    class Rectangle : Shape
    {
        public float Altura { get; set; }
        public float Largura { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(float altura, float largura, Color cor) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        public override float Area()
        {
            return Altura * Largura;
        }

        public override string ToString()
        {
            return $"Retangulo - Cor: {Cor} - Area: {Area().ToString("2f")}";
        }
    }
}
