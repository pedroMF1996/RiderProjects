using System;
using System.IO;

namespace FileStreamStreamReader
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * FileStream - é uma classe que disponibilisa uma stream associada a um arquivo
             *              permitindo operaões de leitura e escrita
             *            - supporte a dados binarios
             * 
             * StreamReader - é uma stram capaz de ler caracteres a partir de uma stream binaria
             *              - Suporte a dados do formato texto
             *              - file/fileInfo
             * 
             */

            string path = @"c:\temp\MyFolder\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //sr = File.OpenText(path);
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);   
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occured: \n{e.Message}");
            }
            finally
            {
                if(sr !=null) sr.Close();
                if(fs!=null) fs.Close();
                
                /*
                 * Outra notação pra fechar 
                 * sr?.Close();
                 * fs?.Close();
                 */
            }
        }
    }
}