using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProdutoFixacao.Entites
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base (nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }
        public double PrecoTotal()
        {
            Preco += TaxaAlfandega;
            return Preco;
        }
        public override string EtiquetaDePreco()
        {
            return ($"{Nome} (Importado): ${PrecoTotal().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}(Taxa Alfandega: ${TaxaAlfandega})"); ;
        }
    }
}
