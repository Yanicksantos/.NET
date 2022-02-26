using System;
using System.Collections.Generic;
using ExercicioEnumFeitoNaMarra.Entites.Enum;

namespace ExercicioEnumFeitoNaMarra.Entites
{
    class Trabalhador
    {
        public Trabalhador()
        {
        }

        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departament { get; set; }
        public List<Contratos> Contrats { get; set; } = new List<Contratos>();
        public int Contador { get; set; } = 0;

        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salarioBase, Departamento departament)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departament = departament;
        }
        public void AdicionarContratos(Contratos contratos)
        {
            Contrats.Add(contratos);
        }
        public void RemoverContratos(Contratos contratos)
        {
            Contrats.Remove(contratos);
        }
        public double Resultado(int ano, int mes)
        {
            double Soma = SalarioBase;
            foreach (Contratos x in Contrats)
            {
                if (mes == x.Data.Month && ano == x.Data.Year)
                {
                    Soma += x.ValorTotal();
                    Contador += 1;
                }
            }
            return Soma;
        }
    }          
}
