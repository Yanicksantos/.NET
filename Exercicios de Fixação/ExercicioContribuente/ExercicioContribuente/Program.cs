using System;
using ExercicioContribuente.Entites;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioContribuente
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> contribuintes = new List<Contribuintes>();
            Console.Write("Entre com o numero de Contruintes: ");
            int cont = int.Parse(Console.ReadLine());
            for (int i =0; i<cont; i++)
            {
                Console.WriteLine($"\nEntre com o Contribuite numero {i+1}");
                Console.WriteLine("-----------------------------------------------");
                Console.Write("Pessoa Fisica ou Pessoa Juridica (PF/PJ): ");
                var resp = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Mensal: ");
                double rendaMensal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double gastoSaude=0.00;
                if (resp.ToUpper() == "PF")
                {
                    try
                    {
                        Console.Write("Gastos com saude: ");
                        gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    }catch(FormatException)
                    {
                        Console.WriteLine("Erro! Desculpe.\nEstamos com dificuldade de entende-lo.\nVamos considerar que nao teve gastos com saude");
                    }
                    finally
                    {
                        contribuintes.Add(new PessoaFisica(nome, rendaMensal, gastoSaude));
                    }  
                }
                else
                {
                    Console.Write("Quantidade de Funcionarios: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(nome, rendaMensal, quantidade));
                }    
            }
            foreach (Contribuintes x in contribuintes)
                Console.WriteLine(x);
            Console.WriteLine("-----------------------------");
            double soma=0;
            foreach (Contribuintes x in contribuintes)
                soma += x.Impostos();
            Console.WriteLine("Total arrecadado: "+soma.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
