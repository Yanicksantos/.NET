using System;
using System.Globalization;

namespace IniciandoAsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Triagulo x, y;
            x = new Triagulo();
            y = new Triagulo();
            Console.WriteLine("digite os valores dos dados A, B e C");
            Console.WriteLine("Primeiro entra com os dados do triangulo x");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Agora entre com os dados do triangulo y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();
            Console.WriteLine($"A area do triangulo x foi {areaX} e do triangulo y foi {areaY}");
            if (areaX > areaY)
                Console.WriteLine("\nArea do triangulo x eh maior");
            else
                Console.WriteLine("\nArea do triangulo y eh maior");
        }
    }
}
