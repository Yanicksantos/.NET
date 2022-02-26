using ParaPortifolio_NumerosRomanos.Utilidades;
using System;

namespace ParaPortifolio_NumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanoToInt Conversor = new RomanoToInt();
            string continuacao;

            Console.WriteLine();
            Console.WriteLine("                       ================ OLA!!! SEJA BEM - VINDO ==============");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Voce entrou nesse programa porque deseja converter numeros romanos em arabico");
            Console.WriteLine("Entao vamos la!!!");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nInformacao importante ABAIXO: ");
            Console.WriteLine("(I = 1) - (V = 5) - (X = 10) - (L = 50) - (C = 100) - (D = 500) - (M = 1000)");

            do
            {
                Console.Write("Entre com o numero romano que deseja converter: ");
                string numeroRomano = Console.ReadLine();
                Conversor.ConvertendoParaInt(numeroRomano.ToUpper());
                Console.WriteLine(Conversor);
                if (Conversor.Contador != 0)
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("Essas letras sao inuteis em numeracao romana (mais atencao pfv): ");
                    foreach (char x in Conversor.LetrasInuteis)
                        Console.Write(x + " ");
                    Console.WriteLine();
                }
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Gostaria de verificar outros numeros que queira saber ou que tenha duvida? ");
                Console.WriteLine("Digite SIM para entrar com o novo numero romano.\nE NAO para TERMINAR...");
                Console.Write("Aguardando: ");
                continuacao = Console.ReadLine();
                if (continuacao.ToUpper() != "SIM" && continuacao.ToUpper() != "NAO")
                    Console.WriteLine("Infelizmente nao conseguimos entende-lo.\nPedimos desculpas. Esperamos ajudar na proxima.\nVolte sempre que quiser!!");
                else
                {
                    if(continuacao.ToUpper() == "SIM")
                    {
                        Conversor.soma = 0;
                        Conversor.Contador = 0;
                        Conversor.NumeroConvertido.Clear();
                        Conversor.LetrasInuteis.Clear();
                    }
                    Console.WriteLine();
                }
            } while (continuacao.ToUpper() == "SIM");
            if (continuacao.ToUpper() == "NAO")
                Console.WriteLine("VOLTE SEMPRE. Esperamos ter te ajudado!");
        }
    }
}

