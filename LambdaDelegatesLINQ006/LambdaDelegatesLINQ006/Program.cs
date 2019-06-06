using System;
using System.Collections.Generic;
using LambdaDelegatesLINQ006.Entities;

namespace LambdaDelegatesLINQ006
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

//            list.ForEach(UpDatePrice);
            Action<Product> act = UpDatePrice;
            Action<Product> act1 = p => {p.Preco += p.Preco * 0.1;};
            list.ForEach(act);
            

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }
 
        static void UpDatePrice(Product p)
        {
            p.Preco += p.Preco * 0.1;
        }
    }
}