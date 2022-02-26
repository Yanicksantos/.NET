using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\file1.txt";
            //FileStream fs = null; usado para ajudar a ler e abrir um arquivo
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(caminho);
                while (!sr.EndOfStream){ //Verifa se chegou no final do arquivo (EndOfStream)
                    //fs = new FileStream(caminho, FileMode.Open); cometado para usar outra forma de resolução
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                    
            }catch (IOException e)
            {
                Console.WriteLine( "ERRO");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
