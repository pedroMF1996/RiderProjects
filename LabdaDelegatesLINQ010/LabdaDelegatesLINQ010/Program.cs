using System;
using System.Collections.Generic;
using LabdaDelegatesLINQ010.Entities;
using System.Globalization;
using System.IO;
using System.Linq;


namespace LabdaDelegatesLINQ010
{
    internal class Program
    {
        public static void Main(string[] args)
        {   
            try
            {
                
                Console.Write("Enter full file path: ");
                string path = Console.ReadLine();
                
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Product> linhas = new List<Product>();
                    while (!sr.EndOfStream)
                    {
                        string[] recive = sr.ReadLine().Split(',');
                        linhas.Add(new Product(recive[0],double.Parse(recive[1],CultureInfo.InvariantCulture)));    
                    }
                    
                    Console.WriteLine("\nProdutos: ");
                    foreach (Product item in linhas)
                    {
                        Console.WriteLine(item);
                    }
                    
                    var name = 
                        (from p in linhas
                            select p.Preco).Average();
                    
                    Console.WriteLine($"\nPreco médio dos produtos: {name.ToString("f2",CultureInfo.InvariantCulture)}");

                    
                    var r2 =
                        (from p in linhas
                            orderby p.Nome descending 
                        where p.Preco < name
                        select p.Nome);
                    
                    Console.WriteLine();
                    foreach (var item in r2)
                    {
                        Console.WriteLine(item);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}