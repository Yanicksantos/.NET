using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioContribuente.Entites
{
    class PessoaFisica : Contribuintes
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaMensal, double gastosSaude): base(nome, rendaMensal)
        {
            GastosSaude = gastosSaude;
        }
        public override double Impostos()
        {
            if (RendaMensal < 20000.00)
                return ((RendaMensal * 0.15) - (GastosSaude * 0.50));
            else
                return ((RendaMensal * 0.25) - (GastosSaude * 0.50));
        }
        public override string ToString()
        {
            return Nome
                +": $"
                +Impostos().ToString("f2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
