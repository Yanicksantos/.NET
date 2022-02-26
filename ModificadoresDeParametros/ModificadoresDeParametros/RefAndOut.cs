using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresDeParametros
{
    class RefAndOut
    {
        public static void TriplarRef (ref int x)
        {
            x = x * 3;
        }
        public static void TriplarOut (int a , out int Triplo)
        {
            Triplo = a * 3;
        }
    }
}
