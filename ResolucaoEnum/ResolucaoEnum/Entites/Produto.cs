﻿
namespace ResolucaoEnum.Entites
{
    class Produto
    {
        public Produto()
        {
        }

        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}