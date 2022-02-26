using System;
using System.IO;

namespace DirectoryDirectoryInfo
    /*Servem para nos fornecer operacoes com pastas*/
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listar as subpastas a partir de uma pasta informada
            string caminho = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\PastaTestes";
            try
            {
                /*IEnumerable<string>*/ var /*(resumindo a declaracao)*/ Pastas = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas: ");
                foreach (string s in Pastas)
                    Console.WriteLine(s);
            }
            catch(IOException e)
            {
                Console.WriteLine("erro!!");
                Console.WriteLine(e.Message);
            }


            //Listar os arquivos a partir de uma pasta informada

            try
            {
                /*IEnumerable<string>*/
                var /*(resumindo a declaracao)*/ arquivos = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nArquivos: ");
                foreach (string a in arquivos)
                    Console.WriteLine(a);
            }
            catch (IOException e)
            {
                Console.WriteLine("erro!!");
                Console.WriteLine(e.Message);
            }


            //Criar pasta

            Directory.CreateDirectory(caminho + @"\NovaPasta_Yanick"); 
        }
    }
}
