using System;
using System.Collections.Generic;

namespace Lista1Ex4
{
    internal class Program
    {
        static public List<int> RemoveDup(List<int> aux)
        {
            List<int> x = new List<int>(); 
            for (int i = 0; i < aux.Count; i++)
            {
                for (int j = i+1; j > i; j--)
                {
                    if (i!=j)
                    {
                        x.Add(aux[i++]);
                    }
                }
            }
            return aux;
        }

        static public int[] RemoveDup(int[] aux)
        {
            int[] x = new int[aux.Length];
            for (int i = 0; i < aux.Length; i++)
            {
                for (int j = i + 1; j > i; j--)
                {
                    if (i!=j)
                    {
                        x[i] = aux[i+1];
                        i++;
                    }
                }
            }
            return aux;
        }
        
        public static void Main(string[] args)
        {
            int[] a = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89};
            List<int> _a = new List<int>();
            _a.Add(1);
            _a.Add(1);
            _a.Add(2);
            _a.Add(3);
            _a.Add(5);
            _a.Add(8);
            _a.Add(13);
            _a.Add(21);
            _a.Add(34);
            _a.Add(55);
            _a.Add(89);

            foreach (int i in a)
            {
                Console.Write($"{i.ToString()} ");
            }

            Console.WriteLine();
            foreach (int j in _a)
            {
                Console.Write($"{j.ToString()} ");
            }
            
            int[] b = RemoveDup(aux: a);
            List<int> _b = RemoveDup(_a);
            Console.WriteLine();
            foreach (int x in b)
            {
                Console.Write($"{x.ToString()} ");
            }

            Console.WriteLine();
            foreach (int y in _b)
            {
                Console.Write($"{y.ToString()} ");
            }
            
        }
    }
}