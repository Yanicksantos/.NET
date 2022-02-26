using System;

namespace ExercicioEnum.Entites
{
    class HourContact // Horas de Contrato
    {
        public HourContact()
        {
        }

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public double Hour { get; set; }

        public HourContact(DateTime date, double valuePerHour, double hour)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }
        public double TotalValue()
        {

            return Hour*ValuePerHour;
        }
    }
}
