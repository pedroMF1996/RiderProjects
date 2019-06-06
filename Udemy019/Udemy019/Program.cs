using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Udemy019.Entitys;

namespace Udemy019
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter full path: ");
            string srcpath = Console.ReadLine();
            try
            {
                string[] lines = File.ReadAllLines(srcpath);
                string targetFolderPath = Path.GetDirectoryName(srcpath);
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);
                
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (var x in lines)
                    {
                        string[] fields = x.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);
                        
                        Produto produto = new Produto(name,price,quantity);

                        sw.WriteLine($"{produto.Nome}, {produto.Total().ToString("f2",CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: \n{e.Message} \n{e.Source}");
            }
        }
    }
}