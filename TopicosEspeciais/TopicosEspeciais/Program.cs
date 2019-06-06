using System;
using System.Globalization;

namespace TopicosEspeciais
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Extention methods
             *
             * Métodos que extendem a funcionalidade de um tipo, sem precisar altear o codigo fonte desse tipo
             * nem herdar desse tipo
             *
             * Como fazer?
             * .Criar uma classe estatica
             * .Na classe, criar um metodo estatico
             * .O primeiro parametro desse metodo devera ter o prefixo this,
             * seguido da declaração de um parametro do tipo que se deseja extender.
             * Esta sera a referencia para o próprio objeto
             */
            
            DateTime dt = new DateTime(2018,11,16,8,10,45);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good mornig dear students!";
            Console.WriteLine($"{s1.Cut(10)}");
            
        }
    }
    
    public static class DateTimeExtentions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            return (duration.TotalHours<24.0)?
                $"{duration.Hours.ToString("f1",CultureInfo.InvariantCulture)} hours" :
                $"{duration.Days.ToString("f1",CultureInfo.InvariantCulture)} days";
        }
    }
    
}