using System;

namespace namespace_IniciandoAsClasses_4
{
    class Program
    {
        static void Main(string[] args)
        {
         /* Fazer um programa para ler os dados de um funcionário (nome, 
         salário bruto e imposto). Em seguida, mostrar os dados do 
         funcionário (nome e salário líquido). Em seguida, aumentar o salário 
         do funcionário com base em uma porcentagem dada (somente o 
         salário bruto é afetado pela porcentagem) e mostrar novamente os 
         dados do funcionário. Use a classe projetada abaixo.*/
            Console.WriteLine("Digite as informacoes do Funcionario!");
            Console.Write("Nome: ");
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = Console.ReadLine();
            Console.Write("\nSalario: ");
            funcionario.Salario = double.Parse(Console.ReadLine());
            Console.Write("\nImposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Funcionario: {funcionario.Nome}, $ {funcionario.SalarioLiquido()}");
            Console.WriteLine("---------------------------------------------------------------");
            Console.Write("\nDigite a percentagem: ");
            double percent = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(percent);
        }
    }
}
