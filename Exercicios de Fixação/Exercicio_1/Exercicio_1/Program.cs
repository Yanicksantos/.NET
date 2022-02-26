using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
   mensagem explicativa, conforme exemplos */

            int a = 10, b = 30;
            int soma = a + b;
            Console.WriteLine(soma);
            a = -30;
            b = 10;
            soma = a + b;
            Console.WriteLine(soma);
            a = 0;
            b = 0;
            soma = a + b;
            Console.WriteLine(soma);
        }
    }
}
