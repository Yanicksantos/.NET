
namespace AprendendoHeranca.Entidades
{
    class ContaBancariaEmpresarial: ContaBancaria
    {
        public ContaBancariaEmpresarial()
        {
        }

        public double LimiteEmprestimo { get; set; }

        public ContaBancariaEmpresarial(int numeroDaConta, string proprietario, double saldoDaConta, double limiteEmprestimo)
            : base(numeroDaConta, proprietario, saldoDaConta)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }
        public void Emprestimo(double valor)
        {
            if (LimiteEmprestimo <= valor)
                SaldoDaConta += valor;
            else
            {
                System.Console.WriteLine("Valor solicitado superior ao seu limite maximo de Emprestimo");
                System.Console.WriteLine("Solicite um novo valor");
                double NovoValor = double.Parse(System.Console.ReadLine());
                Emprestimo(NovoValor);
            }
           
        }
    }
}
