using System;
using HerançaMultipla.Devices;

namespace HerançaMultipla
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080};
            p.PrecessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2003};
            s.PrecessDoc("My Email");
            Console.WriteLine(s.Scan());
            
            ComboDevice c = new ComboDevice()
            {
                SerialNumber = 3921
            };
            c.PrecessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}