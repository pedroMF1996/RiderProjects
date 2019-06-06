using _02_Delegate.Lib;

namespace _02_Delegate
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Foto foto = new Foto()
            {
                Nome = "foto.jpeg",
                Tamanhox = 1920,
                Tamanhoy = 1080
            };
            
            FotoProcessador.Processador(foto);
            
            
        }
    }
}