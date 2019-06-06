using System;
using System.Linq;

namespace _05_LINQ_GROUP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] lista_numero = { 1, 1, 1, 1, 4, 4, 2, 3, 6, 5, 6, 10, 9, 8 };
            
            //group - distinct

            foreach (var item in lista_numero)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var lista_filtrada = lista_numero.Distinct().OrderBy(x=>x);
            foreach (var item in lista_filtrada)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var lista_filtrada2 = lista_numero.GroupBy(a => a);
            foreach (var item in lista_filtrada2)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}