using System;
using System.Collections.Generic;

namespace Lista1Ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100};
            List<int> b = new List<int>();
            
            foreach (int x in a)
            {
                if (x%2==0)
                {
                    b.Add(x);
                }
            }

            foreach (int y in b)
            {
                Console.Write($"{y.ToString()} ");
            }
        }
    }
}