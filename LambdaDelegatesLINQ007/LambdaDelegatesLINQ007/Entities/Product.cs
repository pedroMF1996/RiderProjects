using System;
using System.Globalization;

namespace LambdaDelegatesLINQ007.Entities
{
    public class Product
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString()
        {
            return $"{Nome}, {Preco.ToString("f2",CultureInfo.InvariantCulture)}";
        }

        
    }
}