using ResolucaoEnum.Entites;
using ResolucaoEnum.Entites.Enums;
using System;
using System.Globalization;

namespace ResolucaoEnum
{
    class Program
    {
        public static object Pedido { get; private set; }
        public static object Produto { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do cliente: ");
            Console.Write("Nome: ");
            string clientNome = Console.ReadLine();
            Console.Write("\nE-mail: ");
            string Email = Console.ReadLine();
            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime Aniversario = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(clientNome, Email, Aniversario);
            Console.Write("Status: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Pedido pedido1 = new Pedido(DateTime.Now, Status, cliente);
            Console.WriteLine("Digite dados de pedidos \n---------------------------------------");
            Console.Write("\nQuantos itens vai comprar? ");
            int Quantidade = int.Parse(Console.ReadLine());
            for (int i =1; i<= Quantidade; i++)
            {
                if (Quantidade == 1)
                    Console.WriteLine("Entre com os Dados do Produto, pfv!\n");
                else
                    Console.WriteLine($"Entre com os dados do Produto {i}:");
                Console.Write("Nome do produto: ");
                string Nome = Console.ReadLine();
                Console.Write("\nPreço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                Produto  produto = new Produto(Nome, preco);
                Console.Write("\nQuantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                ItemDoPedido ItemP = new ItemDoPedido(quantidade, produto);
                pedido1.AddItem(ItemP);
            }
            Console.WriteLine("\n================ RESUMO DO PEDIDO ===================");
            Console.WriteLine(pedido1);
        }
    }
}
