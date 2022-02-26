using System;
using System.Globalization;

namespace Restudando
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre os dados do produto:");
            /*Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());
            Produto p = new Produto();*/
            // Uma maneira alternativa de inicializar
            Produto p1 = new Produto
            {
                Nome = Console.ReadLine(),
                Preco = double.Parse(Console.ReadLine()),
            };
            Console.WriteLine("\nDados do produto: " + p1);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine(); 
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
        }
    }
}
