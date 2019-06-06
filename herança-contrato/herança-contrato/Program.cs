using System;
using herança_contrato.Entities;
using herança_contrato.Enums;

namespace herança_contrato
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Radius = 2.0,
                Color = Color.White
            };
            IShape s2 = new Retangle()
            {
                widht = 3.5,
                height = 4.2,
                Color = Color.Black
            };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}