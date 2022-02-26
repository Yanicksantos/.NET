using System;

namespace IniciandoAsClasses_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cota, dol;
            Console.WriteLine("============= Conversor de Moeda(Dolar) ==============");
            Console.Write("Digite a cotacao do dolar: ");
            cota = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("\nQuanto voce tem em dolar? ");
            dol = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Lembre-se que tera que pagar 6% de IOF");
            Console.WriteLine("-------------------------------------------------------");
            double Valor = ConversorDeMoedas.ValorAPagar(cota, dol);
            Console.WriteLine("Valor a ser pago em reais = "+Valor.ToString("f2", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
