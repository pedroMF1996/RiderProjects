using System;

namespace HerançaMultipla.Devices
{
    public class Printer: Device, IPrinter
    {
        public sealed override void PrecessDoc(string document)
        {
            Console.WriteLine($"Scanner processing: {document}");
        }

        public void Print(string document)
        {
            Console.WriteLine($"Printer print: {document}");
        }

        
    }
}