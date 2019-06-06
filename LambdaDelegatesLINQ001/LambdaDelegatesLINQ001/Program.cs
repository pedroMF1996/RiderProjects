using System;
using System.Collections.Generic;
using LambdaDelegatesLINQ001.Entities;

namespace LambdaDelegatesLINQ001
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Comparison<T>
             */
            List<Product> list = new List<Product>();
            list.Add(new Product("TV",900.00));
            list.Add(new Product("Notebook",1200.00));
            list.Add(new Product("Tablet",450.00));
            
            //list.Sort(CompareProducts); <- Delegate: referencia para função com tipe safty
            
            /*  Comparison<Product> comp = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()); 
                list.Sort(comp);
            */
            
            list.Sort((p1,p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));
                

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
            
        }

        static int CompareProducts(Product p1, Product p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
    }
}