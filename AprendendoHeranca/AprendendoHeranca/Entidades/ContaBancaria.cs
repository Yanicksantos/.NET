

namespace AprendendoHeranca.Entidades
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
        public void Saque(double valor)
        {
            SaldoDaConta -= valor;
        }
        public void Deposito(double valor)
        {
            SaldoDaConta += valor;
        }
    }
}
