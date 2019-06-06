using System;
using System.Linq;

namespace _02_LINQ
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

            Console.WriteLine();
            
            var listaFiltrada = from a in lista
                where a > 10
                orderby a
                select a;
            
            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}