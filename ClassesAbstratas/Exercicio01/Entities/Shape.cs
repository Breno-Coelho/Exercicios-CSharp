using Exercicio01.Enums;
using System;
using System.Collections.Generic;

using System.Text;

namespace Exercicio01.Entities
{
    abstract class Shape
    {
        public Color Cor { get; set; }

        public Shape()
        {
        }
        public Shape(Color cor)
        {
            Cor = cor;
        }

        public abstract float Area();
        
    }
}
