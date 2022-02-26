using System;
using ApredendoSobreposicao.Entites;

namespace ApredendoSobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(1000, "Yanick", 5000);
            //ContaPoupanca contaPoupanca = new ContaPoupanca(1000, "Yanick", 5000.00, 0.001);
            //ContaBancaria contaBancaria1 = new ContaPoupanca(1000, "Yanick", 5000.00, 0.001);
            contaBancaria.Saque(100.00);
            //contaPoupanca.Saque(100.00);
            //contaBancaria1.Saque(100.00);
            Console.WriteLine("Testes");
            Console.WriteLine("Conta Bancaria Instaciado normal: "+ contaBancaria.SaldoDaConta);
            contaBancaria = new ContaPoupanca(1000, "Yanick", 5000.00, 0.001);
            contaBancaria.Saque(100.00);

            Console.WriteLine("Conta Poupanca Instanciado normal***: "+contaBancaria.SaldoDaConta);
            
            //Console.WriteLine("Conta Bancaria ou Poupanca, com upcasting: "+contaBancaria1.SaldoDaConta);
        }
    }
}
