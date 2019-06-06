using System;
using System.Collections.Generic;

namespace Lista1Ex1
{
    internal class Program
    {
        static List<int> a = new List<int>();

        public static void Main(string[] args)
        {
            a.Add(1);
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(5);
            a.Add(8);
            a.Add(13);
            a.Add(21);
            a.Add(34);
            a.Add(55);
            a.Add(89);

            List<int> b = new List<int>();
            int aux = a.Count;

            foreach (int Vb in a)
            {
                if (Vb < 5)
                {
                    b.Add(Vb);
                }
            }

            foreach (int x  in b)
            {
                Console.WriteLine($"\n{x.ToString()}");
            }

            Console.Write("Escreva um número de 2 a 89:");
            int num = int.Parse(Console.ReadLine());

            foreach (int y in a)
            {
                if (y<num)
                {
                    Console.WriteLine(y.ToString());
                }
            }
        }
   
    }
}