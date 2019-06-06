using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LambdaDelegatesLINQ009.Entities;

namespace LambdaDelegatesLINQ009
{
    internal class Program
    {
        static void Print<T>(string msg, IEnumerable<T> collection)
        {
            Console.WriteLine(msg);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.WriteLine();
        }
        
        public static void Main(string[] args)
        {
            /*
             * Algebra relacional e SQL - Nivelamento
             *
             * Produto cartesiano
             * Cruzamento de todo mundo com todo mundo
             *
             * Junção
             * Produto carteziando com uma restrição de chaves equivalentes
             *
             * Projeção
             * Como aparecerá na tela
             */
            
            /*
             * Grafia similar ao SQL
             */
            
            
            Category c1 =new Category(1,"tools",2);
         Category c2 = new Category(2,"Computers",1);
         Category c3 = new Category(3,"Eletronics",1);
         
         List<Product> products  = new List<Product>()
         {
             new Product("Computer",1100.00,1,c2),
             new Product("Hammer",90.00,2,c1),
             new Product("TV",1700.00,3,c3),
             new Product("Notebook", 1300.00, 4,c3),
             new Product("Saw",80.0,5,c1),
             new Product("Tablet",700.0,6,c2),
             new Product("Camera",700.0,7,c3),
             new Product("Printer",350.0,8,c3),
             new Product("MacBook",1800.0,9,c2),
             new Product("Sound Bar",700.0,10,c3),
             new Product("Level",70.0,11,c1)
         };
         
        // var r1 = products.Where(x => x.Category.Tier == 1 && x.Preco < 900.0);
        var r1 =
            from p in products
            where p.Category.Tier == 1 && p.Preco < 900.00
            select p;
         
         Print("\nTier 1 AND PRICE < 900: ",r1);

         //var r2 = products.Where(x => x.Category.Name == "tools").Select(x => x.Nome);
         var r2 =
             from p in products
             where p.Category.Name == "tools"
             select p.Nome;
         Print("\nNames of products from tools: ",r2);

         //var r3 = products.Where(x => x.Nome[0] == 'C').Select(p => new {p.Nome,p.Preco, CategoryName = p.Category.Name });
         var r3 =
             from p in products
             where p.Nome[0] == 'C'
             select new
             {
                p.Nome, p.Preco, CategoryNome = p.Category.Name
             };
         Print("\nNames strated with 'C' and anonymous object: ",r3);

         //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x=>x.Preco).ThenBy(x=>x.Nome);
         var r4 =
             from p in products
             where p.Category.Tier == 1
                   orderby p.Nome, p.Preco
             select p;
             
         Print("\nTIER 1 ORDER BY PRICE THEN BY NAME: ",r4);

         //var r5 = r4.Skip(2).Take(4);
         var r5 =
             (from p in products
                 where p.Category.Tier == 1
                 orderby p.Nome, p.Preco
                 select p
                 ).Skip(2).Take(4); 
         Print("\nTIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4: ",r5);

         //var r6 = products.First();
         var r6 = (from p in products
             select p).First();
         Console.WriteLine($"First test 1: {r6.ToString()}");

//         var r7 = products.Where(p => p.Preco > 3000).First();
//         Console.WriteLine($"First test 2: {r7.ToString()}");

        //var r7 = products.Where(p => p.Preco > 3000).FirstOrDefault();
        var r7 =
            (from p in products
                where p.Preco>3000
                select p).FirstOrDefault();
        Console.WriteLine("First or default test 1: " + r7);
        Console.WriteLine();

        //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
        var r8 = 
            (from p in products
            where p.Id ==3
                  select p).SingleOrDefault();
        Console.WriteLine("\nSingle or default test 1: "+r8);
        
//        var r8 = products.Where(p => p.Id == 30).SingleOrDefault();
//        Console.WriteLine("\nSingle or default test 2: "+r8);

        //var r10 = products.Max(p=>p.Preco);
        var r10 = 
            (from p in products
                select p.Preco).Max();
        Console.WriteLine($"Max price: {r10.ToString("f2",CultureInfo.InvariantCulture)}");
        
        //var r11 = products.Min(p=>p.Preco);
        var r11 = 
            (from p in products
                select p.Preco).Min();
        Console.WriteLine($"Min price: {r11.ToString("f2",CultureInfo.InvariantCulture)}");
        
        //var r12 = products.Where(p=>p.Category.ID==1).Sum(p=>p.Preco);
        var r12 = 
            (from p in products
                where p.Category.ID==1
                select p.Preco).Sum();
        Console.WriteLine($"Sum price cat 1: {r12.ToString("f2",CultureInfo.InvariantCulture)}");
        
        //var r13 = products.Where(p=>p.Category.ID==1).Average(p=>p.Preco);
        var r13 = 
            (from p in products
                where p.Category.ID == 1
                      select p.Preco).Average();
        Console.WriteLine($"Average price cat 1: {r13.ToString("f2",CultureInfo.InvariantCulture)}");

        //var r14 = products.Where(p=>p.Category.ID==5).Select(x=>x.Preco).DefaultIfEmpty(0.0).Average();
        var r14 = 
            (from p in products
                where p.Category.ID==5
                      select p.Preco).DefaultIfEmpty(0.0).Average();
        Console.WriteLine($"Average price cat 5: {r14.ToString("f2",CultureInfo.InvariantCulture)}");

        //var r15 = products.Where(p => p.Category.ID == 1).Select(p => p.Preco).Aggregate((x, y) => { return x + y; });
        var r15 = 
            (from p in products
                where p.Category.ID == 1
                      select p.Preco).Aggregate((x, y) => x + y);
        Console.WriteLine($"Category 1 aggregate sum: {r15.ToString()}");
        
        //var r16 = products.Where(p => p.Category.ID == 5).Select(p => p.Preco).Aggregate(0.0, (x, y) => { return x + y; });
        var r16 =
            (from p in products
                where p.Category.ID == 5
                select p.Preco).Aggregate(0.0, (x, y) => { return x + y; });
        Console.WriteLine($"Category 5 aggregate sum: {r16.ToString()}");

        
        //var r17 = products.GroupBy(p => p.Category);
        var r17 =
            from p in products
            group p by p.Category;
        foreach (IGrouping<Category,Product> group in r17)
        {
            Console.WriteLine($"\nCategory {group.Key.Name}: ");
            foreach (Product p in group)
            {
                Console.WriteLine(p);
            }
        }
        }
    }
}