using System;
using System.Globalization;

namespace Entities
{
    class Parcela
    {

        public DateTime DataDeVencimento { get; set; }
        public double Montante { get; set; }

        public Parcela (DateTime dueDate, double montante)
        {
            DataDeVencimento = dueDate;
            Montante = montante;
        }

        public override string ToString()
        {
            return DataDeVencimento.ToString("dd/MM/yyyy")
                + " - "
                + Montante.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}