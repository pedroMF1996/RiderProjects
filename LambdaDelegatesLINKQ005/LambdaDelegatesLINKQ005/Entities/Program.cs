using System;
using System.Collections.Generic;
using LambdaDelegatesLINQ005.Entities;

namespace LambdaDelegatesLINKQ005
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Preco >= 100.00);
            list.RemoveAll(ProductTest);
            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Preco >= 100;
        }
    }
}