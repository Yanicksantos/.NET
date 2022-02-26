using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entites
{
    class Funcionario
    {
        public Funcionario()
        {
        }

        public string Nome { get; set; }
        public int HoraTrabalhdas { get; set; }
        public double ValorDaHora { get; set; }

        public Funcionario(string nome, int horaTrabalhdas, double valorDaHora)
        {
            Nome = nome;
            HoraTrabalhdas = horaTrabalhdas;
            ValorDaHora = valorDaHora;
        }
        public virtual double Pagamento()
        {
            return HoraTrabalhdas*ValorDaHora;
        }
        public override string ToString()
        {
            return Nome 
                + ": $"
                +Pagamento();
        }
    }
}
