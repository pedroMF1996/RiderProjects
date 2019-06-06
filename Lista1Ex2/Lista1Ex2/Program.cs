using System;
using System.Collections.Generic;
using Lista1Ex2.CompletarLista;

namespace Lista1Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();

            a = Completar.Fibonachi(11);
            b = Completar.Sequencial(13);

            foreach (int x in a)
            {
                foreach (int y in b)
                {
                    if (x==y)
                    {
                        Console.Write($"{x.ToString()} ");
                    }
                }
            }

        }
    }
}