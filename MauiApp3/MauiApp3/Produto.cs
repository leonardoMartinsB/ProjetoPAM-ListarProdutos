using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp3
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Smartphone", Preco = 1200, Categoria = "Eletrônicos", QuantidadeEmEstoque = 50 });
                lista.Add(new Produto() { Nome = "Televisor", Preco = 2500, Categoria = "Eletrônicos", QuantidadeEmEstoque = 30 });
                lista.Add(new Produto() { Nome = "Fone de Ouvido", Preco = 150, Categoria = "Eletrônicos", QuantidadeEmEstoque = 100 });
                lista.Add(new Produto() { Nome = "Laptop", Preco = 4500, Categoria = "Eletrônicos", QuantidadeEmEstoque = 20 });
                lista.Add(new Produto() { Nome = "Smartwatch", Preco = 700, Categoria = "Eletrônicos", QuantidadeEmEstoque = 80 });

                return lista;
            }
        }
    }
}