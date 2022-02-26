using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutoFixacao.Entites
{
    class Produto
    {

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {
        }

        public virtual string EtiquetaDePreco()
        {
            return ($"{Nome}: ${Preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
        }
        public override string ToString()
        {
            return EtiquetaDePreco();
        }
    }
}
