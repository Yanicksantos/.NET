using System;
using System.Globalization;

namespace ContaBancaria
{
    class ContaUsuario
    {

        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public ContaUsuario(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaUsuario(int numero, string nome, double valor): this(numero, nome)
        {
            Valor = valor;
        }
        public void Deposito(double dinheiro)
        {
            Valor += dinheiro;
        }
        public void Saque(double dinheiro)
        {
            Valor -= (dinheiro + 5);
        }
        public override string ToString()
        {
            return "Informacoes Atuais\n"
            + "Numero Da Conta: "
            + Numero
            + ", Nome:  "
            + Nome.ToUpper()
            + ", Valor Em Conta: $"
            + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
