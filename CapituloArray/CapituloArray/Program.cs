using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nullable é um recurso para dar a possiblidade de uma variavel do tipo valor (struct)
            possa receber valor nulo (null)*/

            Nullable<double> x = null; 
            double? y = null;// melhor maneira de escrever o codigo de cima (Atribuição do valor nulo na variavel double)

            /*O Nullable tem 3 operações básicas {GetValueOrDefaut; HasValue; Value}*/

            y = 10;
            Console.WriteLine("ESSE EH O RTESULTADO DA FUNCAO GetValueOrDefaut");
            Console.WriteLine("X = "+x.GetValueOrDefault());
            Console.WriteLine("Y = "+y.GetValueOrDefault());
            /* Essa função pega o valor x se existir, caso seja nulo envia o valor
            padrao do tipo da variavel*/

            Console.WriteLine("\nESSE EH O RESULTADO DA FUNCAO HasValue");
            Console.WriteLine("X = "+x.HasValue);
            Console.WriteLine("Y = "+y.HasValue);
            /*Essa funcao verifica se a variavel tem ou nao valor. Se sim, retorna True
             caso seja nulo, ele envia false*/

            Console.WriteLine("ESSE EH O RESULTADO DA FUNCAO Value");
            Console.WriteLine("Y = "+y.Value);
            // Console.WriteLine("X = "+x.Value); ERRO
            /*ELE PEGA O VALOR QUE ESTÁ NA VARIAVEL. CASO SEJA NULA E TENTAR IMPRIMIR MESMO 
             ASSIM, DÁ ERRO. É LEGAL USAR USANDO COMANDOS CONDICIONAIS OU FAZER 
            TRATAMENTO DE ERRO*/
            
            //OPERADOR DE COALESCENCIA NULA (EX: Y = X?? 0)
            Console.WriteLine("Coalescencia");
            y = x ?? 20.00;
            Console.WriteLine(y);
            int? z = 15;
            y = z ?? 20; //Ira imprimir 15 pq a variavel z não é nula. A verificação termina 
            // reconhece que não é necessário atribuir o Valor 20. 
            Console.WriteLine(y);

        }
    }
}
