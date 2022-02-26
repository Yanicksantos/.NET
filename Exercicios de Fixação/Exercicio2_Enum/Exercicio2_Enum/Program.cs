using System;
using Exercicio2_Enum.Entites;

namespace Exercicio2_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma otima viagem!!");
            Comentario c2 = new Comentario("QUE LEGAL");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"), 
                "Viagem para nova zilandia", "Vou Aproveitar o maximo que puder", 12);
            p1.AddComentarios(c1);
            p1.AddComentarios(c2);
            Console.WriteLine(p1);
        }

    }
}
