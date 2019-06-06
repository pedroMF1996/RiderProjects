using System;
using System.IO;

namespace StreamWriter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * StreamWriter - É uma stream capaz de escrever caracteres a partir de uma stream binaria
             * Suporte a dados do formato texto
             *
             * instanciação:
             * ctor
             * File/FileInfo
             */
            string srcPath = @"c:\temp\MyFolder\file1.txt";
            string trgtPath = @"c:\temp\MyFolder\file4.txt";
            try
            {
                string[] lines = File.ReadAllLines(srcPath);

                using (System.IO.StreamWriter sw = File.AppendText(trgtPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occured: \n{e.Message}");
            }
        }
    }
}