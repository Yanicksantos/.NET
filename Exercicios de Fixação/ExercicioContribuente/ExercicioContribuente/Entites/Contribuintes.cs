using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioContribuente.Entites
{
    abstract class Contribuintes
    {
        public string Nome { get; set; }
        public double RendaMensal { get; set; }
        public Contribuintes(string nome, double rendaMensal)
        {
            Nome = nome;
            RendaMensal = rendaMensal;
        }
        public abstract double Impostos();

        
    }
}
