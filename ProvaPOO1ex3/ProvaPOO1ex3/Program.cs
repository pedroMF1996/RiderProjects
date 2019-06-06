using System;
using System.Globalization;
using ProvaPOO1ex3.Entities;

namespace ProvaPOO1ex3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com o Y: ");
            double y = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double yraiz = RaizQuadrada.PrimeiraAprox(y); 
            
            for (int i = 0; i < 50; i++)
            {
                yraiz = RaizQuadrada.AproxSubSeq(yraiz, y);
            }

            Console.WriteLine($"A RAIZ QUADRADA DE Y = {y.ToString("F2")} é {yraiz.ToString("F2")}");
        }
    }
}