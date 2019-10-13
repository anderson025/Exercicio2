using System.Globalization;

namespace Exercicio2.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            this.Preco = preco;
        }

        public virtual string EtiquetaPreco()
        {
            return Nome + " $ " + Preco.ToString("F2", CultureInfo.InstalledUICulture);
        }
    }
}
