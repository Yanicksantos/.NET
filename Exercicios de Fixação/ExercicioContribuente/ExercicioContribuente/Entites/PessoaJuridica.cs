using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioContribuente.Entites
{
    class PessoaJuridica: Contribuintes
    {
        public int NumeroP { get; set; }

        public PessoaJuridica(string nome, double rendaMensal, int numeroP)
            : base (nome, rendaMensal)
        {
            NumeroP = numeroP;
        }

        public override double Impostos()
        {
            if (NumeroP < 10)
                return (RendaMensal * 0.16);
            else
                return (RendaMensal * 0.14);
        }
        public override string ToString()
        {
            return Nome
                + ": $"
                + Impostos().ToString("f2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
