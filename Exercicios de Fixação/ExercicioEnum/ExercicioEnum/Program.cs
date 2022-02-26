using System;
using ExercicioEnum.Entites.Enums;
using ExercicioEnum.Entites;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome do Departamento: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Entre com os Dados do trabalhador!!!\n-----------------------------");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nNivel(Junior/MidLevel/Senior): ");
            WorkerLevel nivel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("\nSalario Basico: ");
            double salarioBase = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Department departamento = new Department(depName); /* Primeira Class chamada
                                                                com preenchimento do construtor*/
            Worker trabalhador = new Worker(nome, nivel, salarioBase, departamento); /* Segunda 
                                                                                      Class 
                                                                                      chamada 
                                                                                      com 
                                                                                      preenchimento 
                                                                                      do 
                                                                                     construtor*/
            Console.WriteLine("Quantos Contratos para esse trabalhador?");
            int quantDeContratos = int.Parse(Console.ReadLine());
            for (int i =1; i <= quantDeContratos; i++)
            {
                Console.WriteLine($"Entre com os dados do {i} contrato");
                Console.Write("Data(DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Horas Trabalhadas: ");
                int horaTrabalhada = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------------------");
                HourContact contract = new HourContact(date, valorPorHora, horaTrabalhada);
                trabalhador.AddContract(contract);
            }
            Console.WriteLine("\nEntre com o mes/ano: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            // Mostrar os Resultados
            Console.WriteLine("Nome: "+trabalhador.Nome);
            Console.WriteLine("Departament: " +trabalhador.Department.Name);
            Console.WriteLine("Ganhos de "+ mesAno+": "+ trabalhador.Incame(ano, mes).ToString("f2", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
