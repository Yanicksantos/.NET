using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHerancaPolimorfismo.Entites
{
    class FuncionarioTercerizado: Funcionario
    {
        public double Dispesas { get; set; }

        public FuncionarioTercerizado(string nome, int horaTrabalhdas, double valorDaHora, double dispesas)
            : base(nome, horaTrabalhdas, valorDaHora)
        {
            Dispesas = dispesas;
        }
        public override double Pagamento()
        {
            return (base.Pagamento()+(Dispesas*1.1));

        }
         public override string ToString()
        {
            return Nome 
                + " (Tercerizado): $"
                +Pagamento();
        }
    }
}
