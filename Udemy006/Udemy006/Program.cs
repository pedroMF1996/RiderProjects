using System;
using Udemy006.Classes;
namespace Udemy006
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2,3);
            int s2 = Calculator.Sum(2,4,3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            
            Calculator.Triple(ref s1);
            Console.WriteLine(s1);
            
            int triple;
            Calculator.Triple(s1,out triple);
            Console.WriteLine(triple);
            
        }
    }
}