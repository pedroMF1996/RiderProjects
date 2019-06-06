using System;
using System.Collections.Generic;
using System.Linq;
using Udemy005.Classes;
namespace Udemy005
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented?");
            int qte = int.Parse(Console.ReadLine());
            List<Aluguel> aluguels = new List<Aluguel>(qte);
            for (int i = 0; i < qte; i++)
            {
                Console.WriteLine($"Rent #{(i+1).ToString()}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                aluguels.Add(new Aluguel(
                                    nome:name,
                                    email:email,
                                    quarto:room
                             )
                );
            }

            aluguels.Sort();

            foreach (Aluguel x in aluguels)
            {
                Console.WriteLine(x);
            }
        }
    }
}