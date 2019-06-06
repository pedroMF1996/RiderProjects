using System;
using System.Collections.Generic;

namespace Udemy007
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();
            
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine($"List Count: {list.Count.ToString()}");

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);
            
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos);
            
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (var VARIABLE in list2)
            {
                Console.WriteLine(VARIABLE);
            }

            /*
            Console.WriteLine();
            list.Remove("Alex");
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine();
            list.RemoveAll(x => x[0] == 'M');
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
            
            list.RemoveAt(1);
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }*/
            Console.WriteLine();
            list.RemoveRange(2,2);
            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}