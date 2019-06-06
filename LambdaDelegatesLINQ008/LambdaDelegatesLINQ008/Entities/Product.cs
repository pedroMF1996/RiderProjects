using System;
using System.Globalization;

namespace LambdaDelegatesLINQ008.Entities
{
    public class Product
    {
        public int Id { get;  set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Category Category { get; set; }
        

        public Product(string nome, double preco, int id, Category category)
        {
            Nome = nome;
            Preco = preco;
            Id = id;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Id.ToString()}, {Nome}, {Preco.ToString("f2",CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier.ToString()}";
        }

        
    }
}