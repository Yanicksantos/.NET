using System;

namespace namespace_IniciandoAsClasses_4
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;
        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double percentagem)
        {
            Salario += percentagem /100* Salario;
            double novaSalarioLiq = Salario - Imposto;
            Console.WriteLine($"Dados Atualizados: {Nome}, $ {novaSalarioLiq}");
        }
    }
}
