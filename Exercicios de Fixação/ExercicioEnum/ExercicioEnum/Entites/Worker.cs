using System;
using ExercicioEnum.Entites.Enums;
using System.Collections.Generic;

namespace ExercicioEnum.Entites
{
    class Worker
    {
        public Worker()
        {
        }

        public string Nome { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContact> Contracts { get; set; } = new List<HourContact>();

        public Worker(string nome, WorkerLevel level, double baseSalary, Department department)
        {
            Nome = nome;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContact contract)
        {
            Contracts.Add(contract);
        }
        public double Incame (int year, int month) //Class Para os ganhos
        {
            double Soma = BaseSalary;
            foreach (HourContact Contrat in Contracts)
            {
                if (Contrat.Date.Year == year && Contrat.Date.Month == month)
                    Soma += Contrat.TotalValue();
            }
            return Soma;
        }
    }
}
