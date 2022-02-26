using System;
using System.Collections.Generic;
using System.Text;

namespace ApredendoSobreposicao.Entites
{
    class ContaPoupanca: ContaBancaria
    {
        public ContaPoupanca()
        {
        }

        public double TaxaDeJuros { get; set; }

        public ContaPoupanca(int numeroDaConta, string proprietario, double saldoDaConta, double taxaDeJuros)
            :base (numeroDaConta, proprietario, saldoDaConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }
        public void ContaAtualizada()
        {
            SaldoDaConta += (SaldoDaConta * TaxaDeJuros);
        }
        public override void Saque(double valor)
        {
            base.Saque(valor);
            SaldoDaConta += 5;
        }
    }
}
