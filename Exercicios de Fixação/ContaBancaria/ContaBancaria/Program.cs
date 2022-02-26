using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaUsuario Conta;
            Console.Write("Entre com o numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("\nEntre Com o nome do Titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Vai fazer algum deposito agora?\n---------------------------\nDigite 1 - para SIM e 2- para NAO");
            int Esc = int.Parse(Console.ReadLine());
            if (Esc == 1)
            {
                Console.Write("Digite o Valor do Deposito: ");
                double valor = double.Parse(Console.ReadLine());
                Conta = new ContaUsuario(numero, nome, valor);
            }
            else
                Conta = new ContaUsuario(numero, nome);
            Console.WriteLine(Conta);
            Console.Write("\nMOMENTO DE DEPOSITO OBRIGATÓRIO (mesmo que tenha feito deposito na abertura da conta).\nDigite de o valor do DEPOSITO: ");
            double Deposito = double.Parse(Console.ReadLine());
            Conta.Deposito(Deposito);
            Console.WriteLine(Conta);
            Console.WriteLine("\nPara Concluirmos esse TOUR, pfv realize um saque.\nINFORMACAO IMPORTANTE: Sera cobrado uma taxa de 5 reais pra Cada Saque!!");
            Console.WriteLine("Quanto pretende sacar? ");
            double saque = double.Parse(Console.ReadLine());
            Conta.Saque(saque);
            Console.WriteLine(Conta);
            Console.WriteLine("\n============= AGRADECEMOS A ABERTURA DA SUA CONTA ============");
        }
    }
}
