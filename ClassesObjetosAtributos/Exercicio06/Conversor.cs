using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    class Conversor
    {
        public static float Converte(float x, float y)
        {
            return (x * y) + ((x * y) * 0.06f);
        }
    }
}
