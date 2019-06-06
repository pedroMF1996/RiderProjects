namespace Udemy006.Classes
{
    public class Calculator
    {
        public static int Sum(params int[] numbers)//codigo para aceitar mais de um parametro
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                sum += x;
            }

            return sum;
        }

        public static void Triple(ref int x)
        {
            x *= 3;
        }    
        public static void Triple(int original, out int x)
        {
            x = original * 3;
        }    
    }
}