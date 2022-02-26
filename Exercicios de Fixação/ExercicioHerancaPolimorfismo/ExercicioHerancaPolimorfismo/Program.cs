using System;
using System.Collections.Generic;
using ExercicioHerancaPolimorfismo.Entites;

namespace ExercicioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionario = new List<Funcionario>();
            Console.Write("Entre com o numero de funcionarios: ");
            int NumeroFunc = int.Parse(Console.ReadLine());
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Agora pode inserir os dados de cada funcionario!");
            for (int i =0; i<NumeroFunc; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("\nHoras Trabalhadas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("\nValor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("\nTercerizado? : ");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "NAO" || resposta.ToUpper() == "N")
                    funcionario.Add(new Funcionario(nome, horas, valorPorHora));
                else
                {
                    Console.Write("\nValor da Despesas:");
                    double valorDespesas = double.Parse(Console.ReadLine());
                    funcionario.Add(new FuncionarioTercerizado(nome, horas, valorPorHora, valorDespesas));
                }  
            }
            Console.WriteLine("--------------------------------------------------------------");
            foreach (Funcionario x in funcionario)
                Console.WriteLine(x);
        }
    }
}
