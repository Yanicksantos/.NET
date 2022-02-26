using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEnumFeitoNaMarra.Entites
{
    class Contratos
    {
        public Contratos()
        {
        }

        public DateTime Data { get; set; } = new DateTime();
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public Contratos(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora*Horas;
        }

    }
}
