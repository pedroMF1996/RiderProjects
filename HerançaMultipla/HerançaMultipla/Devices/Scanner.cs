using System;

namespace HerançaMultipla.Devices
{
    public class Scanner: Device, IScanner
    {
        public sealed override void PrecessDoc(string document)
        {
            Console.WriteLine($"Scanner processing: {document}");
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}