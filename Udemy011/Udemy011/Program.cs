using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy011.Classes;

namespace Udemy011
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Entre com o numero de figuras: ");
            int qte = int.Parse(Console.ReadLine());
            for (int i = 0; i < qte; i++)
            {
                Console.WriteLine($"Entre com os dados da figura {(i+1).ToString()}");
                Console.Write("Qual é o tipo da figura (r/c): ");
                Console.Write("Cor (Black/Blue/Red): ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());
                string tp = Console.ReadLine();
                if (tp == "r")
                {
                    Console.Write("Quanto mede o lado: ");
                    double lado = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Quanto mede a altura: ");
                    double altura = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(lado,altura,cor));
                }
                else
                {
                    Console.Write("Quanto mede o raio: ");
                    double raio = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Circle(raio,cor));
                }
            }

            foreach (Shape x in list)
            {
                Console.WriteLine($"{x.area().ToString("f2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}