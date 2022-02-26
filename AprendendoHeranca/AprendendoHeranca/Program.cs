using System;
using AprendendoHeranca.Entidades;

namespace AprendendoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();
            ContaBancariaEmpresarial contaBancariaEmpresarial = new ContaBancariaEmpresarial();
            /*Console.WriteLine(contaBancaria.SaldoDaConta);
            contaBancaria.SaldoDaConta = 0; Saldo da conta ta limitado o acesso apenas 
                                             pra class e subclass ContaBancaria*/

                         //UPCASTING (conversões possiveis de subclass para superclass)
            ContaBancaria contaBancaria1 = contaBancariaEmpresarial; 
            ContaBancaria contaBancaria2 = new ContaBancariaEmpresarial(1004, "ANA", 10000, 1000.00);
            ContaBancaria contaBancaria3 = new ContaPoupanca();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

                       // DOWNCASTING (conversões possiveis de Superlass para Subclass)
            ContaBancariaEmpresarial contaBancariaEmpresarial1 = (ContaBancariaEmpresarial)contaBancaria2;
            contaBancariaEmpresarial1.Emprestimo(100);
            ContaBancariaEmpresarial contaBancariaEmpresarial2 = (ContaBancariaEmpresarial)contaBancaria3;
            /*Não é muito usado, por motivos de segurança. Precisando muito de testes.
             Usar so em situações muiiiitos necessárias*/
        }
    }
}
