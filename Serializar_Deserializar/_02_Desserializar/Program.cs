using System;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_Desserializar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\temp\01_SerializarXML.xml");
            
            XmlSerializer serializador = new XmlSerializer(typeof(Usucario));
            Usucario usucario = (Usucario)serializador.Deserialize(sr);

            Console.WriteLine(usucario);
        }
    }
}