using System;
using _00_Biblioteca;
using System.IO;
using System.Web.Script.Serialization;

namespace _04_DesserializarJSON
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"c:\temp\02_SerializarJSON.json"))
            {
                string linhasDoArquivo = sr.ReadToEnd();
                
                JavaScriptSerializer desserializador = new JavaScriptSerializer();
                Usucario usuario = (Usucario)desserializador.Deserialize(linhasDoArquivo,typeof(Usucario));

                Console.WriteLine(usuario);
            }
        }
    }
}