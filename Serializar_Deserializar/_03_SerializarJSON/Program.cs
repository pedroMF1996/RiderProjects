using System.IO;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _03_SerializarJSON
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Usucario usuario = new Usucario()
            {
                Nome = "Maria Costa Silva",
                CPF = "3333.3333.3333-00",
                Email = "maria.costa@gmail.com"
            };
            
            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjetoSerializado = serializador.Serialize(usuario);

            using (StreamWriter sw = new StreamWriter(@"C:\temp\02_SerializarJSON.json"))
            {
                sw.WriteLine(stringObjetoSerializado);
            } 
            
        }
    }
}