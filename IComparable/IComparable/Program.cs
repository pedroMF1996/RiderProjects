using System;
using System.Collections.Generic;
using System.IO;
using IComparable.Entities;

namespace IComparable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    
                    list.Sort();
                    foreach (Employee funcionario in list)
                    {
                        Console.WriteLine(funcionario);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}