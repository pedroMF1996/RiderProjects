using System;
using System.IO;

namespace FileFileInfoIOException
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * File - operações estaticas, File.Alteração
             *      - realiza operações de segurança a cada vez que for chamada, mais lento
             * 
             * FileInfo - Instancia objetos, nao faz as verificações de segurança, mais rapido
             *
             * IOException - Super classe de todas as exceções possiveis que podem acontecer quando se irá trabalhar com arquivo
             *     DirectoryNotFoundException
             *     DriveNotFoundException
             *     EndOFStreamException
             *     FileLoadException
             *     FileNotFoundException
             *     PathTooLongException
             *     PipeException
             */

            string srcPath = @"c:\temp\MyFolder\file1.txt";//Caminho do arquivo de origem
            string trgtPath = @"c:\temp\MyFolder\file3.txt";//caminho do arquivo de destino

            try
            {
                FileInfo fileInfo = new FileInfo(srcPath);
                fileInfo.CopyTo(trgtPath);
                
                string[] lines = File.ReadAllLines(srcPath);
                foreach (string x in lines)
                {
                    Console.WriteLine(x);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occured: \n{e.Message}");
                throw;
            }
            
            
        }
    }
}