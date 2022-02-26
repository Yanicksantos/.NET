using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutoFixacao.Entites
{
    class ProdutoUsado : Produto
    {

        public DateTime Data { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime data)
            : base(nome, preco)
        {
            Data = data;
        }
        public override string EtiquetaDePreco()
        {
            return ($"{Nome} (Usado): ${Preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}(Data de Fabricacao: {Data.ToString("d")})");
        }
        public override string ToString()
        {
            return EtiquetaDePreco();
        }
    }
}
