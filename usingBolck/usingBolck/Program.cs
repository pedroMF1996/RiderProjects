using System;
using System.IO;

namespace usingBolck
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Using block - sintaxe simplificada que garante que os objetos IDisposible serão fechados.
             *  Os objetos IDisposible não são gerenciados pelo CLR. Eles precisam ser manualmente fechados:
             *     Exemplo: Font, FileStream, StreamReader, StreamWriter;
             */

            string path = @"c:\temp\MyFolder\file1.txt";
            /*try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: \n" + e.Message);
            }*/

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: \n" + e.Message);
                throw;
            }
        }
    }
}