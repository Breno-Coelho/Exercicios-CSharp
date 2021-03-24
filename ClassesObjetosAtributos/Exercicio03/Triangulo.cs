using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    class Triangulo
    {
        public float Largura;
        public float Altura;

        public float Area(float x, float y)
        {   
            return x * y;
        }

        public float Perimetro(float x, float y)
        {
            return 2 * x + 2 * y; 
        }

        public float Diagonal(float x, float y)
        {
            float h = x * x + y * y;
            return (float)Math.Sqrt(h);
        }
    }
}
