using System;
using System.Collections.Generic;
using System.Text;

namespace IniciandoAsClasses_2
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantity)
        {
            int novaQuant = quantity;
            Quantidade += novaQuant;
        }
        public void RemoverProdutos(int quantity)
        {
            int novaQuant = quantity;
            Quantidade -= novaQuant;
        }
        public override string ToString()
        {
            return "Nome: " 
                + Nome + " - Preco: " 
                + Preco + " - Quantidade: " 
                + Quantidade + " - Valor Total de Estoque: " 
                + ValorTotalEmEstoque().ToString("f2");
        }
    }
}
