using System;
using System.Collections.Generic;
using ExercicioProdutoFixacao.Entites;

namespace ExercicioProdutoFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Console.Write("Entre com a quantidade de produtos: ");
            int quantidade = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            for (int i=0; i<quantidade; i++)
            {
                Console.WriteLine($"Entre com o Produto #{i+1}");
                Console.Write("Informe se o produto eh usado, importado ou comum (u/i/c): ");
                char esc = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());
                if (esc == 'u')
                {
                    Console.Write("Informe a data de fabricacao: ");
                    DateTime date = new DateTime();
                    date = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, date));
                }
                else if (esc == 'i')
                {
                    Console.Write("Informe a taxa: ");
                    double taxa = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else
                    produtos.Add(new Produto(nome, preco));
            }
            Console.WriteLine("-------------------------------------------------");
            foreach (Produto x in produtos)
                    Console.WriteLine(x);
        }
    }
}
