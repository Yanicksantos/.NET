using System;
using System.Collections.Generic;

namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantiadde de linha e coluna que quer respectivamente: ");
            int Linha = int.Parse(Console.ReadLine());
            int Coluna = int.Parse(Console.ReadLine());
            int[,] Matriznum = new int[Linha, Coluna];
            List<int> ListPos = new List<int>();
            List<int> ListCol = new List<int>();
            for (int i = 0; i < Linha; i++)
            {
                Console.WriteLine($"Preencha a {i + 1} Linha");
                for (int j = 0; j < Coluna; j++)
                {
                    Matriznum[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < Linha; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < Coluna; j++)
                {
                    Console.Write(" " + Matriznum[i, j]);
                }
            }
            Console.Write("\nDigite um numero existente na matriz, pfv: ");
            int cont = 0;
            int NumMatriz;
            do
            {
                NumMatriz = int.Parse(Console.ReadLine());
                for (int i= 0; i<Linha; i++)
                {
                    for (int j=0; j<Coluna; j++)
                    {
                        if (NumMatriz == Matriznum[i,j])
                        {
                            ListPos.Add(i);
                            ListCol.Add(j);
                            cont += 1;
                        }
                    }
                }
                if (cont == 0)
                    Console.Write("\nPfv, olhe os numeros que pertecem a Matriz.\nESCOLHE UM DELES: ");
                else
                {
                    for (int i = 0; i < ListPos.Count; i++)
                    {
                        Console.WriteLine($"{NumMatriz} esta na posicao: ({ListPos[i]},{ListCol[i]})");
                        int cima = ListPos[i] - 1;
                        if (cima >= 0 && cima < Linha)
                            Console.WriteLine($"CIMA: {Matriznum[cima, ListCol[i]]}");
                        int esquerda = ListCol[i] - 1;
                        if (esquerda >= 0 && esquerda < Coluna)
                            Console.WriteLine($"ESQUERDA: {Matriznum[ListPos[i], esquerda]}");
                        int direita = ListCol[i] + 1;
                        if (direita < Coluna)
                            Console.WriteLine($"DIREITA: {Matriznum[ListPos[i], direita]}");
                        int baixo = ListPos[i] + 1;
                        if (baixo < Linha)
                            Console.WriteLine($"BAIXO: {Matriznum[baixo, ListCol[i]]}");
                    }
                }
            } while (cont == 0);
           
        }
    }
}
