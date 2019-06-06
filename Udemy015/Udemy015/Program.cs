using System;
using System.IO;

namespace Udemy015
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        string srcPath = @"c:\temp\file1.txt";//declarando o caminho do arquivo origem
        try
        {
         /*   using (FileStream fs = new FileStream(srcPath, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }*/
         using (StreamReader sr = File.OpenText(srcPath))
         {
             while (!sr.EndOfStream)
             {
                 string line = sr.ReadLine();
                 Console.WriteLine(line);
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