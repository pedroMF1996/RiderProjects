using System;

namespace ProvaPOO1ex4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com as datas: ");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("DIA: ");
                int D = Int32.Parse(Console.ReadLine());
                Console.WriteLine("MES: ");
                int M = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ano: ");
                int A = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{D.ToString()}/{M.ToString()}/{A.ToString()}");
                
                
            }
        }
    }
}