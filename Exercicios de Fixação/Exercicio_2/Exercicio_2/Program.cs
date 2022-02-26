using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula da área: area = π.raio2
Considere o valor de π = 3.14159 */

            Console.WriteLine("Digite o valor do raio, pfv");
            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;
            double CirculoArea = pi * Math.Pow(raio, 2);
            Console.WriteLine("A area do raio eh: "+ CirculoArea.ToString("f2", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
