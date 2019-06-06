using System;
using System.IO;

namespace Udemy016
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string srcPath = @"c:\temp\file1.txt";//origem
            string trgtPath = @"c:\temp\file2.txt";//destindo
            try
            {
                string[] lines = File.ReadAllLines(srcPath);

                using (StreamWriter sw = File.AppendText(trgtPath))
                {
                    foreach (var x in lines)
                    {
                        sw.WriteLine(x.ToUpper()); 
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: \n{e.Message}");
                
            }
        }
    }
}