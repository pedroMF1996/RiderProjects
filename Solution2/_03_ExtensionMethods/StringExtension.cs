using System;
using System.Linq;

namespace _03_ExtensionMethods
{
    public static class StringExtension 
    {
        public static string FirstToUpper(this string str)
        {
            string result = str.Substring(0,1).ToUpper();
            result += str.Substring(1);
            return result;
        }
    }
}