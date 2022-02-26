using System;

namespace IniciandoAsClasses_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o 
            nome da pessoa mais velha*/
            Console.WriteLine("Por favor entre com os dados das duas pessoas!");
            Console.Write("Entre com o nome da 1 pessoa: ");
            DadosPessoa pessoa = new DadosPessoa();
            pessoa.Nome = Console.ReadLine();
            Console.Write("\nAgora entre com a idade dela: ");
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Entre com o nome da 2 pessoa: ");
            DadosPessoa pessoa1 = new DadosPessoa();
            pessoa1.Nome = Console.ReadLine();
            Console.Write("\nAgora entre com a idade dela: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------");
            DadosPessoa.MaiorDelas(pessoa.Idade, pessoa.Nome, pessoa1.Idade, pessoa1.Nome);
        }
    }
}
