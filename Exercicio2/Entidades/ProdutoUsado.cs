using System;

namespace Exercicio2.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string EtiquetaPreco()
        {
            return Nome + " (usado) $ " + Preco + " Data de Fabricação:" + DataFabricacao;
        }
    }
}
