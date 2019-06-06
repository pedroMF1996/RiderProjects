using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy009.Classes;
namespace Udemy009
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the numbers of employees: ");
            int qte = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < qte; i++)
            {
                Console.WriteLine($"Employee #{(i+1).ToString()} data:");
                Console.Write("Outsourced (y/n)? ");
                string os = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double vH = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (os=="y")
                {
                    Console.Write("Additional charge: ");
                    double addC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name,hours,vH,addC));
                }
                else
                {
                    employees.Add(new Employee(name,hours,vH));
                }
            }
            employees.Sort();

            foreach (var VARIABLE in employees)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }
}