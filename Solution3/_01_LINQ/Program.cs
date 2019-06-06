using System;
using System.Linq;

namespace _01_LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 20, 10, 60, 90, 80} ;

            var r = lista.Where(x => x % 2 != 0).OrderByDescending(a=>a);

            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
            
            
            
        }
    }
}