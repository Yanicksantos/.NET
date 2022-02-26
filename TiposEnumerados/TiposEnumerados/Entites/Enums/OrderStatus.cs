using System;

namespace TiposEnumerados.Entites.Enums
{
    enum OrderStatus: int
    {
        PendingPayment, //Pagamento Pendente 
        Processing = 1, // Processando
        Shipped = 2, // Enviado
        Delivered = 3 // Entregue
    }
}
