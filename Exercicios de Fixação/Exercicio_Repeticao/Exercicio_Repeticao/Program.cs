using System;

namespace Exercicio_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Escreva um programa que repita a leitura de uma senha até que ela seja válida.
            Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".
            Quando a senha for informada corretamente deve ser impressa a mensagem 
         "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

            Console.WriteLine("Pfv Digite a senha Correta: ");
            int senha = int.Parse(Console.ReadLine());
            int cont = 0;
            while (senha != 2002 && cont <= 2)
            {
                if (cont==0)
                    Console.WriteLine("Voce tem mais 3 tentativas!!!!");
                Console.WriteLine("\nSenha Invalida! Pfv Digite novamente a senha correta: ");
                senha = int.Parse(Console.ReadLine());
                cont++;
            }
            if (senha == 2002)
                Console.WriteLine("\nACESSO PERMITIDO");
            else
                Console.WriteLine("\nAcesso bloqueado!! VOCE ESGOTOU O NUMERO DE TENTATIVAS.");
            -------------------------------------------------------------------------------------
            
             
            Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, 
            um valor por linha, inclusive o se for o caso.
             */
            int x;
            Console.WriteLine("Digite o numero inteiro: ");
            do
            {
                Console.WriteLine("Lembrete: valor inteiro para X e deve pertecer a esse intervalo (1 <= X <= 1000)");
                x = int.Parse(Console.ReadLine());
            } while ( x < 1 || x > 1000);
            Console.WriteLine("\nOs numeros impares ate x sao: ");
            for (int i = 1; i <= x; i++)
            {
                if (i%2 != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
