using System;

namespace _02_Delegate.Lib
{
    public class FotoProcessador
    {
        public static void Processador(Foto foto)
        {
            var filtros = new FotoFiltro();
            filtros.Colorir(foto);
            filtros.PretoBranco(foto);
            filtros.GerarThumb(foto);
            filtros.RedimencionarMedio(foto);
        }
    }
}