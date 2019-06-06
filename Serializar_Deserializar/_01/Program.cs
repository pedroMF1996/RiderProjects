using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Usucario usuario = new Usucario()
            {
                Nome = "José Costa Silva",
                CPF = "2222.2222.2222-22",
                Email = "jose@gmail.com"
            };
            
            //XmlSerializer serializador = new XmlSerializer(typeof(Usucario));
            XmlSerializer serializador = new XmlSerializer(usuario.GetType());
            StreamWriter sw = new StreamWriter(@"C:\temp\01_SerializarXML.xml");
            serializador.Serialize(sw, usuario);
        }
    }
}