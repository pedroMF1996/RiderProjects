using System;
using System.IO;

namespace Udemy018
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";
            
            Console.WriteLine($"DirectorySeparatorChar: {Path.DirectorySeparatorChar.ToString()}");
            Console.WriteLine($"PathSeparator: {Path.PathSeparator.ToString()}");
            Console.WriteLine($"GetDirectoryName: {Path.GetDirectoryName(path)}");
            Console.WriteLine($"GetFileName: {Path.GetFileName(path)}");
            Console.WriteLine($"GetFileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}");
            Console.WriteLine($"GetExtention: {Path.GetExtension(path)}");
            Console.WriteLine($"GetFullPath: {Path.GetFullPath(path)}");
            Console.WriteLine($"GetTempPath: {Path.GetTempPath()}"); 
        }
    }
}