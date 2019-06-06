using System;
using System.Collections.Generic;
using System.IO;

namespace Udemy017
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      string srcPath = @"c:\temp\MyFolder";
      try
      {
        IEnumerable<string> folder =  Directory.EnumerateDirectories(srcPath,"*.*",SearchOption.AllDirectories);
        Console.WriteLine("Folders: ");
        foreach (var x in folder)
        {
          Console.WriteLine(x);
        }
        
        IEnumerable<string> files =  Directory.EnumerateFiles(srcPath,"*.*",SearchOption.AllDirectories);
        Console.WriteLine("Files: ");
        foreach (var x in files)
        {
          Console.WriteLine(x);
        }

        Directory.CreateDirectory(srcPath + @"\newFolder");
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error: \n{e.Message}");
      }
    }
  }
}