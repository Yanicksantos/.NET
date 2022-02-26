using System;

namespace ExercicioArray_Vetor_
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] Aluno = new Aluguel[10];
            int QuartDisp, numeroq;
            Console.WriteLine("Quantos Alunos estao dispostos a alugar?");
            do
            {
                Console.Write("Lembrete: So temos 10 quartos Disponivel: ");
                QuartDisp = int.Parse(Console.ReadLine());
            } while (QuartDisp < 1 || QuartDisp > 10);
            for (int i = 0; i <= QuartDisp - 1; i++)
            {
                Console.WriteLine("Digite o nome do " + (i+1) + " Aluno");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o seu email (Pfv digite email valido, nao iremos verifica-lo)");
                string email = Console.ReadLine();
                do
                {
                   Console.WriteLine("Digite Agora o numero do quarto que ele escolheu estar (1 a 10):  ");
                   numeroq = int.Parse(Console.ReadLine());
                } while (numeroq < 1 || numeroq > 10);
                Aluno[i] = new Aluguel(nome, email, numeroq);
            }
            Console.WriteLine("Aqui estao as informacoes do aluguel dos alunos!");
            for (int i =0; i<= 10; i++)
            {
                if (Aluno[i] != null)
                    Console.WriteLine(Aluno[i]);
            }  
        }
    }
}