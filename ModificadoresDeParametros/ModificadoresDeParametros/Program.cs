using System;

namespace ModificadoresDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificador de Parametro (Params)
            int s1 = Params.FuncaoParaTestarParams(2,3,4,5,7,8);
            Console.WriteLine(s1);


            //Modificador de Parametro Ref
            int a = 10, x;
            RefAndOut.TriplarRef(ref a);
            Console.WriteLine(a);


            //Modificador de Parametro Out
            RefAndOut.TriplarOut(a, out x);
            Console.WriteLine(x);
        }
    }
}
