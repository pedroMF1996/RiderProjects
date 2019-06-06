using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using LambdaDelegatesLINQExercicioFixacao.Entities;

namespace LambdaDelegatesLINQExercicioFixacao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                Console.Write("Enter full path :");
                string path = Console.ReadLine();
                Console.WriteLine("Enter salary: ");
                double salary = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] recive = sr.ReadLine().Split(',');
                        employees.Add(new Employee(recive[0],recive[1],double.Parse(recive[2],CultureInfo.InvariantCulture))); 
                    }


                    var emails =
                        from e in employees
                        where e.Salary > salary
                        select e.Email;
                    Console.WriteLine("Email of people whose salary is more than 2000.00: ");
                    foreach (var email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    var sumSalary =
                        (from e in employees
                            where e.Name[0] == 'M'
                            select e.Salary)
                        .Sum();
                    Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sumSalary.ToString("f2",CultureInfo.InvariantCulture)}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}