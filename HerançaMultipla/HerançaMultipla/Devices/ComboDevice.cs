using System;

namespace HerançaMultipla.Devices
{
    public class ComboDevice: Device, IScanner, IPrinter
    {
        public override void PrecessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing: {document}");            
        }

        public string Scan()
        {
            return "Combo device scan result";
        }

        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice print: {document}");
        }
    }
}