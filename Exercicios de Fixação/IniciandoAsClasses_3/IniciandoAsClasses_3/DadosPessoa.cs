using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoAsClasses_3
{
    class DadosPessoa
    {
        public string Nome;
        public int Idade;
        public static void MaiorDelas(int idade1, string nome1, int idade2, string nome2)
        {
            if (idade1>idade2)
                Console.WriteLine($"{nome1} tem {idade1} anos. Logo, ele(a) eh mais velho(a).\nPara lembrar que o {nome2} tem {idade2} anos ");
            else if (idade1 == idade2)
                Console.WriteLine($"{nome1} e {nome2} tem a mesma idade. Ninguem é o mais velho.");
            else
                Console.WriteLine($"{nome2} tem {idade2} anos. Logo, ele(a) eh mais velho(a).\nPara lembrar que o {nome1} tem {idade1} anos ");
        }
    }
}
