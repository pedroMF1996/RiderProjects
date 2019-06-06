using System;
using System.Collections.Generic;
using LambdaDelegatesLINQ007.Entities;
using System.Linq;

namespace LambdaDelegatesLINQ007
{
    internal class Program
    {
        public static void Main(string[] args)
        {
          /* Delegate
           * Func
           * Representa um metodo que recebe zero ou mais argumentos, e retorna um valor
           *
           * 
           */
          
          List<Product> list = new List<Product>();
          
          list.Add(new Product("Tv", 900.00));
          list.Add(new Product("Mouse", 50.00));
          list.Add(new Product("Tablet", 350.50));
          list.Add(new Product("HD Case", 80.90));

//          List<string> lists = list.Select(NameUpper).ToList();
//
//          foreach (string s in lists)
//          {
//              Console.WriteLine(s);
//          }

//            Func<Product, string> func = NameUpper;
//
//            List<string> lists = list.Select(func).ToList();
//
//            foreach (string s in lists)
//            {
//                Console.WriteLine(s);
//            }

//            Func<Product, string> func = p => p.Nome.ToUpper();
//            
//            List<string> lists = list.Select(func).ToList();
//
//            foreach (string s in lists)
//            {
//                Console.WriteLine(s);
//            }
            List<string> lists = list.Select(p => p.Nome.ToUpper()).ToList();
            foreach (string s in lists)
            {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Nome.ToUpper();
        }
    }
}