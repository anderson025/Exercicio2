using System.Globalization;
namespace Exercicio2.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandefa { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandefa) : base(nome, preco)
        {
            TaxaAlfandefa = taxaAlfandefa;
        }

        public override string EtiquetaPreco()
        {
            ProdutoImportado p = new ProdutoImportado();
            
            return Nome + " $ " + p.PrecoTotal().ToString("F2", CultureInfo.InstalledUICulture) + $"(Taxa Alfandega: $ {TaxaAlfandefa})";
            //return base.EtiquetaPreco() + $"(Taxa Alfandega: $ {TaxaAlfandefa})";
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandefa;
        }
    }
}
