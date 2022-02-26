using System;
using System.IO;

namespace StreamWriters
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file1.txt";
            string destino = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(caminho);
                using(StreamWriter sw = File.AppendText(destino))
                {
                    foreach (string line in lines)
                        sw.WriteLine(line.ToUpper());
                }
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
