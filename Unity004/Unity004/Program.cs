using System;
using System.Globalization;
using Unity004.Classes;

namespace Unity004
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            int n = int.Parse(Console.ReadLine());
            
            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            */

            int qte = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[qte];

            for (int i = 0; i < qte; i++)
            {
                produtos[i] = new Produto(
                    Console.ReadLine(),
                    Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture)
                    );
            }

            double sum = 0.0f;
            for (int j = 0; j < qte; j++)
            {
                sum += produtos[j].Preco;
            }
            
            Console.WriteLine($"AVERAGE PRICE = $ {(sum/qte).ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}