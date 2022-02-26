using System.Collections.Generic;

namespace ParaPortifolio_NumerosRomanos.Utilidades
{
    class RomanoToInt
    {
        public string NumeroRomano { get; set; }
        public List<int> NumeroConvertido = new List<int>();
        public List<char> LetrasInuteis = new List<char>();
        public int Contador { get; set; } = 0;
        public int soma { get; set; }

        public void ConvertendoParaInt(string NRomano)
        {
            NumeroRomano = NRomano;
            for (int i = 0; i < NumeroRomano.Length; i++) //Colacando as equivalencias corretas
            {
                if (NumeroRomano[i] == 'I')
                    NumeroConvertido.Add(1);
                else if (NumeroRomano[i] == 'V')
                    NumeroConvertido.Add(5);
                else if (NumeroRomano[i] == 'X')
                    NumeroConvertido.Add(10);
                else if (NumeroRomano[i] == 'L')
                    NumeroConvertido.Add(50);
                else if (NumeroRomano[i] == 'C')
                    NumeroConvertido.Add(100);
                else if (NumeroRomano[i] == 'D')
                    NumeroConvertido.Add(500);
                else if (NumeroRomano[i] == 'M')
                    NumeroConvertido.Add(1000);
                else
                {
                    LetrasInuteis.Add(NumeroRomano[i]);
                    Contador += 1;
                }
            }
        }

        public int DescubrindoNumero(List<int> numeroConvertido)
        {
            for (int i = 0; i < numeroConvertido.Count; i++)
            {
                if ((i + 1) < numeroConvertido.Count) // Garantindo a existencia do próximo numero
                {
                    /*LÓGICA: Todo numero que tiver um numero maior que ele na sequencia,
                     esta disponivel para ser usado subtraindo*/
                    if (numeroConvertido[i] < numeroConvertido[i + 1])
                        soma -= numeroConvertido[i];
                    //Caso contrario, pode soma-lo
                    else
                        soma += numeroConvertido[i];
                }
                else //Em numeros romanos, a ultima letra sempre estará somando
                    soma += numeroConvertido[i];
            }
            return soma;
        }
        public override string ToString()
        {
            return "-------------------------\n"
                +NumeroRomano
                +" Equivale a "
                + DescubrindoNumero(NumeroConvertido);
        }
    }
}
