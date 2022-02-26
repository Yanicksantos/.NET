using System;
using System.IO;
using System.Collections.Generic;

namespace ClassPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\YANICK\Desktop\Rumo a PROGRAMADOR\C#\ApredendoArquivos\PastaTestes";
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.DirectorySeparatorChar);
            Console.WriteLine(Path.PathSeparator);
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetTempPath());
        }
    }
}
