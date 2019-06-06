using System;

namespace Udemy003
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Nullable<double> x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value);//vai dar erro se tentar chamar um nullable que está valendo null
            //Console.WriteLine(y.Value);
            
            string resultado = (x.HasValue)?
                $"{x.Value.ToString()}":
                "X é nulo";
            Console.WriteLine(resultado);
            
            string resultadoy = (y.HasValue)?
                $"{y.Value.ToString()}":
                "Y é nulo";
            Console.WriteLine(resultadoy);

            double? a = null;
            double? b = x ?? 0.0;
            
            string resultadoa = (a.HasValue)?
                $"{a.Value.ToString()}":
                "A é nulo";
            Console.WriteLine(resultadoa);
            
            string resultadob = (b.HasValue)?
                $"{b.Value.ToString()}":
                "B é nulo";
            Console.WriteLine(resultadob);

            
        }
    }
}