using System;
using System.Collections.Generic;
using System.Text;

namespace ModificadoresDeParametros
{
    class Params
    {
        public static int FuncaoParaTestarParams(params int [] vetor)
        //A funcao Params permite receber parametro variaveis. Dando flexibilidade ao usuario
        {
            int sum = 0;
            for (int i = 0; i < vetor.Length; i++)
                sum += vetor[i];
            return sum;
        }
    }
}
