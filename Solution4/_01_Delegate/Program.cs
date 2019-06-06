using System;

namespace _01_Delegate
{
    internal class Program
    {
        delegate int Calcula(int a, int b);
        public static void Main(string[] args)
        {
//            int so = Soma(10, 20);
//
//            int su = Subtracao(10, 20);

//            Console.WriteLine($"{so.ToString()}\n{su.ToString()}");

            Calcula calc = new Calcula(Soma);
            Console.WriteLine(calc(10, 20));

            calc = Subtracao;

            Console.WriteLine(calc(30,15));

        }

        public static int Soma(int a, int b)
        {
            return a + b;
        } 
        public static int Subtracao(int a, int b)
        {
            return a - b;
        } 
    }
}