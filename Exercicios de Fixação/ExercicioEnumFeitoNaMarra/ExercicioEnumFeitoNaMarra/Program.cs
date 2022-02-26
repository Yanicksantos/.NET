using System;
using System.Globalization;
using ExercicioEnumFeitoNaMarra.Entites;
using ExercicioEnumFeitoNaMarra.Entites.Enum;

namespace ExercicioEnumFeitoNaMarra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola!!!\nInforme abaixo o Departamento para comecarmos: ");
            Departamento departamento = new Departamento();
            departamento.Nome = Console.ReadLine();
            Console.WriteLine("Certo. Agora entre com os dados do Funcionario");
            Console.Write("Nome: ");
            string nomeFuncionario = Console.ReadLine();
            Console.Write("\nNivel(Estagiario/ Junior/ Pleno/ Senior): ");
            NivelDoTrabalhador nivelDoTrabalhador = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());
            Console.Write("\nSalario Base: ");
            double salarioBase = double.Parse(Console.ReadLine());
            Trabalhador trabalhador = new Trabalhador(nomeFuncionario, nivelDoTrabalhador, salarioBase, departamento);
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Agora digite a quantidade de contratos que pretende entrar em detalhes: ");
            int quantdade = int.Parse(Console.ReadLine());
            for (int i =1; i <= quantdade; i++)
            {
                if (quantdade == 1)
                    Console.WriteLine("Digite os Dados do Contratos");
                else
                    Console.WriteLine($"Entre com os dados do {i} Contrato");
                Console.Write("Data (DD/MM/YYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("\nValor Cobrado Por Hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("\nHoras Trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());
                Contratos contrat = new Contratos(data, valorPorHora, horasTrabalhadas);
                trabalhador.AdicionarContratos(contrat);
            }
            Console.WriteLine("Entre com o mes e o ano para o calculo do RESULTADO (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Nome : " + trabalhador.Nome);
            Console.WriteLine("Departamento: " + trabalhador.Departament.Nome);
            if (trabalhador.Contador == 0)
            {
                Console.WriteLine("\nRenda para " + mesAno + " : " + trabalhador.Resultado(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("=================================================");
                Console.WriteLine("Informamos que nao teve adicional no mes solicitado.\nPor isso, so recebeu o Salario base!!");
            }
            else
                Console.WriteLine("Renda para " + mesAno + " : " + trabalhador.Resultado(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
