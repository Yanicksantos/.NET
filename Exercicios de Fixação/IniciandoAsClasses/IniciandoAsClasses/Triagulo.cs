using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoAsClasses
{
    class Triagulo
    {
        public double A;
        public double B;
        public double C;
        double raiz;
        public double Area()
        {
            double p = ( A + B + C) / 2.0;
            return raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
