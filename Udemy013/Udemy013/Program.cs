using System;
using System.IO;
namespace Udemy013
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string srcPath = @"c:\temp\file1.txt";//declarando o caminho do arquivo origem

            string targetPath = @"c:\temp\file2.txt";//declarando o caminho do arquivo destino

            try
            {
                FileInfo fileInfo = new FileInfo(srcPath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(srcPath);
                foreach (string x in lines)
                {
                    Console.WriteLine(x);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error occurred: \n{e.Message}");
            }

        }
    }
}