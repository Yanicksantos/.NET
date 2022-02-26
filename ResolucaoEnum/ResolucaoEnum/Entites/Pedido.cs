using System;
using System.Collections.Generic;
using System.Text;
using ResolucaoEnum.Entites.Enums;

namespace ResolucaoEnum.Entites
{

    class Pedido
    {

        public DateTime Moment { get; set; } 
        public OrderStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemDoPedido> Item { get; set; } = new List<ItemDoPedido>();
        public Pedido()
        {
        }
        public Pedido(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }


        //  Todos os Atributos
        public void AddItem(ItemDoPedido item)
        {
            Item.Add(item);
        }
        public void RemoveItem(ItemDoPedido item)
        {
            Item.Remove(item);
        }
        public double Total()
        {
            double Total = 0;
            foreach (ItemDoPedido ContTotal in Item)
                Total += ContTotal.SubTotal();
            return Total;
        }
        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();
            txt.Append("Momento do Pedido: ");
            txt.AppendLine(Moment.ToString("G"));
            txt.Append("Status do Pedido: ");
            txt.AppendLine(Status.ToString());
            txt.AppendLine(Cliente.ToString());
            txt.AppendLine("Produtos do Pedido:");
            foreach (ItemDoPedido itens in Item)
            {
                txt.AppendLine(itens.ToString());
            }
            txt.AppendLine("----------------------------------------------");
            txt.Append("Total a Pagar: ");
            txt.Append(Total().ToString());
            return txt.ToString();
        }
       
    }
}
