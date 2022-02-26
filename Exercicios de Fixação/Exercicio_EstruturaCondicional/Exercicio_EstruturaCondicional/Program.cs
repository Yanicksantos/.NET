using System;

namespace Exercicio_EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

            Console.WriteLine("Digite o numero: ");
            double num = double.Parse(Console.ReadLine());
            if (num < 0)
                Console.WriteLine($"NUMERO {num} EH NEGATIVO !");
            else if (num == 0)
                Console.WriteLine("Ce digitou ZERO");
            else
                Console.WriteLine($"NUMERO {num} EH POSITVO");
            --------------------------------------------------------------------------------

            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
seguir, calcule e mostre o valor da conta a pagar.
             */
            Console.WriteLine("[1 - Cachorro Quente, 2 - XSalada, 3 - XBacon, 4 - Torrada Simples, 5 - Refrigerante ]\n");
            Console.WriteLine("Digite o codigo do item: ");
            int cod = int.Parse(Console.ReadLine());
            string[] nomes = new string[] { "Cachorro Quente", "X-Salada", "X-Bacon", "Torrada Simples", "Refrigerante" };
            Console.WriteLine("Agora voce pode escolher a quantidade: ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (cod)
                {
                case 1 :
                    Console.WriteLine($"Voce escolheu {cod} - {nomes[0]}");
                    double preco = 4.0 * quant;
                    Console.WriteLine($"A unidade de {nomes[0]} custa 4.00 reais, voce pediu {quant} unidades.\nVoce vai precisar pagar {preco} reais");
                    break;
                case 2:
                    Console.WriteLine($"Voce escolheu {cod} - {nomes[1]}");
                    preco = 4.5* quant;
                    Console.WriteLine($"A unidade de {nomes[1]} custa 4.50 reais, voce pediu {quant} unidades.\nVoce vai precisar pagar {preco} reais");
                    break;
                case 3:
                    Console.WriteLine($"Voce escolheu {cod} - {nomes[2]}");
                    preco = 5.0 * quant;
                    Console.WriteLine($"A unidade de {nomes[2]} custa 5.00 reais, voce pediu {quant} unidades.\nVoce vai precisar pagar {preco} reais");
                    break;
                case 4:
                    Console.WriteLine($"Voce escolheu {cod} - {nomes[3]}");
                    preco = 2.0 * quant;
                    Console.WriteLine($"A unidade de {nomes[3]} custa 2.00 reais, voce pediu {quant} unidades.\nVoce vai precisar pagar {preco} reais");
                    break;
                case 5:
                    Console.WriteLine($"Voce escolheu {cod} - {nomes[4]}");
                    preco = 1.5 * quant;
                    Console.WriteLine($"A unidade de {nomes[4]} custa 1.50 reais, voce pediu {quant} unidades.\nVoce vai precisar pagar {preco} reais");
                    break;
            }
        }
    }
}
