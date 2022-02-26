using System;
using System.IO;

namespace UsingBloco
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file1.txt";
            try
            {
                // using (FileStream fs = new FileStream(caminho, FileMode.Open)) /*jeito mais longo*/
                // {
                using (StreamReader sr = File.OpenText(caminho)) /*Apos a execucao do bloco using, 
                                                                   o arquivo instanciado é fechado*/
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro!!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
