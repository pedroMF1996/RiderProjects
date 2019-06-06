using System;

namespace _02_Delegate.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto)
        {
            Console.WriteLine("Colorimento realizado");
        }

        public void GerarThumb(Foto foto)
        {
            Console.WriteLine("Gerar thumb");
        }

        public void PretoBranco(Foto foto)
        {
            Console.WriteLine("Imagem convertida para preto e branco");
        }

        public void RedimencionarMedio(Foto foto)
        {
            Console.WriteLine("Foto redimentcionada");
        }
    }
}