using System;

namespace IniciandoAsClasses_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Prod = new Produto();
            Console.WriteLine("Entre com os Dados do produto");
            Console.Write("Nome: ");
            Prod.Nome = Console.ReadLine();
            Console.Write("\nPreco: ");
            Prod.Preco = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("\nQuantidade: ");
            Prod.Quantidade = int.Parse(Console.ReadLine());
            double quant_total = Prod.ValorTotalEmEstoque();
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine("================ Dados do Produto Inserido ====================");
            Console.WriteLine(Prod);
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine($"OPAAAA!!!\nNotamos que voce pretende adicionar mais produtos de {Prod.Nome} no estoque!");
            Console.Write($"Qual a quantidade que pretende adicionar de {Prod.Nome}: ");
            int novaQ = int.Parse(Console.ReadLine());
            Prod.AdicionarProdutos(novaQ);
            Console.WriteLine(Prod);
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine($"OPAAAA!!!\nNotamos que voce pretende Retirar mais produtos de {Prod.Nome} no estoque!");
            Console.Write($"Qual a quantidade que pretende retirar de {Prod.Nome}: ");
            novaQ = int.Parse(Console.ReadLine());
            Prod.RemoverProdutos(novaQ);
            Console.WriteLine(Prod);
        }
    }
}
