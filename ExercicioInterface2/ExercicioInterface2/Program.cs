using System;
using System.Globalization;
using Entities;
using Servicos;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os Dados do Contrato");
            Console.Write("Numero: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o numero de Parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contract meuContrato = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessarContrato(meuContrato, months);

            Console.WriteLine("Parcelas:");
            foreach (Parcela parcela in meuContrato.parcelas)
            {
                Console.WriteLine(parcela);
            }
        }
    }
}