using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoHeranca.Entidades
{
    class ContaPoupanca: ContaBancaria
    {

        public double TaxaDeJuros { get; set; }
        public ContaPoupanca()
        {
        }

        public ContaPoupanca(int numeroDaConta, string proprietario, double saldoDaConta, double taxaDeJuros)
            : base(numeroDaConta, proprietario, saldoDaConta)
        {
            TaxaDeJuros = taxaDeJuros;
        }

        public void AtualizarSaldoConta()
        {
            SaldoDaConta += (SaldoDaConta * TaxaDeJuros);
        }
    }
}
