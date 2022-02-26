using System;
using System.IO;
namespace ApredendoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminhoDeOrigem = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file1.txt";
            string caminhoDeDestino = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file2.txt";
            try
            {
                FileInfo file = new FileInfo(caminhoDeOrigem);
                file.CopyTo(caminhoDeDestino);
                string[] lines = File.ReadAllLines(caminhoDeOrigem);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!\n"+e.Message);
            }
        }
    }
}
