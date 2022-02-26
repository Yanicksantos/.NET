using System;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetorTeste = new string[] { "Pedro", "Yanick", "Manuel" };
            foreach (string p in vetorTeste)
            {
                Console.WriteLine(p);
            }
        }
    }
}
