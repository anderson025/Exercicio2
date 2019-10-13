using Exercicio2.Entidades;
using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Lista = new List<Produto>();

            Console.Write("Entre com o numero de produtos:");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Produto #{i}");

                Console.Write("Comum, Usado , Importado (C/U/I)?");
                char valor = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine());

                if (valor == 'i')
                {
                    Console.WriteLine("Taxa Alfandega: ");
                    double taxa = double.Parse(Console.ReadLine());                   


                    Lista.Add(new ProdutoImportado(nome, preco, taxa));
                }
                else if (valor == 'u')
                {
                    Console.Write("Data de fabricação: (DD/MM/YYYY) ");
                    string data = Console.ReadLine();
                    DateTime dt = DateTime.Parse(data);
                    Lista.Add(new ProdutoUsado(nome, preco, dt));
                }
                else
                {
                    Lista.Add(new Produto(nome, preco));
                }


            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta de Preço");

            foreach (Produto p in Lista)
            {
                Console.WriteLine(p.EtiquetaPreco());
            }

            




        }
    }
}