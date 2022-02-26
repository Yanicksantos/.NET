using System;

namespace ExercicioDeFixacaoBebado
{
    class Program
    {
        static void Main(string[] args)
        {
            /* fazer um programa para ler o nome de um aluno e as três notas que ele obteve 
             * nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro 
             * valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer 
             * também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos 
             * pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). 
             * Você deve criar uma classe Aluno para resolver este problema.
             */
            Aluno Aluno = new Aluno();
            Console.WriteLine("Digite o Nome do Aluno por favor: ");
            Aluno.Nome = Console.ReadLine();
            Console.WriteLine($"Por favor agora inicie a digitar as tres notas do aluno {Aluno.Nome}");
            Aluno.Nota1 = double.Parse(Console.ReadLine());
            Aluno.Nota2 = double.Parse(Console.ReadLine());
            Aluno.Nota3 = double.Parse(Console.ReadLine());
            double media = Aluno.Media();
            if (media < 60)
            {
                double falta = 60 - media;
                Console.WriteLine($"voce ta reprovado!!\nTa faltando {falta} pra passar");
            }
            else
                Console.WriteLine($"Voce foui aprovado com {media} valores. Parabens!!!");

        }
    }
}
