using System.IO;
using System.Web.Script.Serialization;

namespace _01_Generics
{
    public class Serializador
    {
        public static void Serializar(object obj)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\temp\03_"+obj.GetType().Name+".txt"))
            {
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                string objSerializado = serializador.Serialize(obj);
                sw.Write(objSerializado);
            }
        }

        public static T Deserializar<T>()
        {
            using (StreamReader sr = new StreamReader(@"C:\temp\03_"+typeof(T).Name+".txt"))
            {
                string conteudo = sr.ReadToEnd();
                
                JavaScriptSerializer serializador = new JavaScriptSerializer();
                T obj = (T) serializador.Deserialize(conteudo,typeof(T));
                
                return obj;
            }
        }
    }
}