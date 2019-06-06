using System;
using System.IO;

namespace Udemy014
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string srcPath = @"c:\temp\file1.txt";//declarando o caminho do arquivo origem
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(srcPath, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: \n{e.Message}");
            }
            finally
            {
                if (sr != null) sr.Close();
                if(fs != null) fs.Close();
            }

        }
    }
}