using System;

namespace _03_ExtensionMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string valor = "olá mundo!";
                
                Console.WriteLine(valor.FirstToUpper());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}