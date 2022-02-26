using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> MinhaLista = new List<string>();
            List<string> LISYA = new List<string> { "maria", "PEDRO", "YANICK" };

            // Inserir elemento na lista (Add, Insert)
            List<int> ListaTest1 = new List<int>();
            ListaTest1.Add(1); // Adicionar o numero 1 na lista (sempre na proxima posicao vazia)
            Console.WriteLine(ListaTest1[0]);
            ListaTest1.Insert(0, 3);
            Console.WriteLine(ListaTest1[0]);


            //Tamanho da Lista
            Console.WriteLine(ListaTest1.Count);

        }
    }
}
