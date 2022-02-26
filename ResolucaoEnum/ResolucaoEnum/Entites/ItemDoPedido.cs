using System.Globalization;

namespace ResolucaoEnum.Entites
{
    class ItemDoPedido
    {
        public ItemDoPedido()
        {
        }

        public int Quantidade { get; set; }
        public Produto Product { get; set; }

        public ItemDoPedido(int quantidade, Produto product)
        {
            Quantidade = quantidade;
            Product = product;
        }

        public double SubTotal()
        {
            return Product.Preco * Quantidade;
        }


        public override string ToString()
        {
            return Product.Nome
                + ", $"
                + Product.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
