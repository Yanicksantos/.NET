using System;
using TiposEnumerados.Entites;
using TiposEnumerados.Entites.Enums;

namespace TiposEnumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            Order Order = new Order // Pequeno teste 
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(Order);

            String texto = OrderStatus.PendingPayment.ToString(); /* Conversão tipo enumerado
                                                                   para tipo string*/
            Console.WriteLine(texto);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); /*Conversão de tipo string 
                                                                   para tipo enumerado*/
            Console.WriteLine(os);
        }
    }
}
