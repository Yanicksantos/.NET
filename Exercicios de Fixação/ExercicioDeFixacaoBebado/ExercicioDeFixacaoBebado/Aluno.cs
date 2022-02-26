using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDeFixacaoBebado
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double Media()
        {
            double Media = (Nota1 * 30 + Nota2 * 35 + Nota3 * 35) / 100.00;
            return Media;
        }
    }
}
