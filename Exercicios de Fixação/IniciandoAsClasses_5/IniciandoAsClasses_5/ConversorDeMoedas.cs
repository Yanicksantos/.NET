using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoAsClasses_5
{
    class ConversorDeMoedas
    {
        public static double ValorAPagar(double Cotacao, double dolar)
        {
            return ((Cotacao*dolar) + ((Cotacao*dolar)*0.06));
        }

    }
}
