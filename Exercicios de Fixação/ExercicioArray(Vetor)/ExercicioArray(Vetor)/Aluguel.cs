using System;

namespace ExercicioArray_Vetor_
{
    class Aluguel
    {
        public string NomeEstudante;
        public string EmailEstudante;
        public int NumeroQuarto;

        public Aluguel(string nomeEstudante, string emailEstudante, int numeroQuarto)
        {
            NomeEstudante = nomeEstudante;
            EmailEstudante = emailEstudante;
            NumeroQuarto = numeroQuarto;
        }
        public override string ToString()
        {
            return NumeroQuarto + ": " + NomeEstudante + " -- " + EmailEstudante; 
        }
    }
}
