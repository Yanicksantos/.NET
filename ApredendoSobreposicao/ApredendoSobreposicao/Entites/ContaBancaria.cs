using System;
using System.Collections.Generic;
using System.Text;

namespace ApredendoSobreposicao.Entites
{
    class ContaBancaria
    {
        public ContaBancaria()
        {
        }

        public int NumeroDaConta { get; set; }
        public string Proprietario { get; set; }
        public double SaldoDaConta { get; protected set; }

        public ContaBancaria(int numeroDaConta, string proprietario, double saldoDaConta)
        {
            NumeroDaConta = numeroDaConta;
            Proprietario = proprietario;
            SaldoDaConta = saldoDaConta;
        }
        public virtual void Saque(double valor)
        {
            SaldoDaConta -= (valor+5);
        }
        public void Deposito(double valor)
        {
            SaldoDaConta += valor;
        }
    }
}
