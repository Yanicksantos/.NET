using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler quatro valores inteiros A, B, C e D.A seguir, calcule e mostre a diferença do produto
  de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D). 

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int Dif = (num1 * num2) - (num3 * num4);
            Console.WriteLine("Diferenca = " +Dif);
            ----------------------------------------------------------
            
            Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            
            string [] vet = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(vet[0]);
            int num1 = int.Parse(vet[1]);
            Double valor1 = double.Parse(vet[2], System.Globalization.CultureInfo.InvariantCulture);

            string[] vet1 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet1[0]);
            int num2 = int.Parse(vet1[1]);
            Double valor2 = double.Parse(vet1[2], System.Globalization.CultureInfo.InvariantCulture);

            double solucao = (num1*valor1) + (num2*valor2);
            Console.WriteLine("Valor a pagar: "+solucao.ToString("f2"));
            
             -----------------------------------------------------------------------------
             */

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
