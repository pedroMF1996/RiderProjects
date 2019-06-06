using System;
using _01_Generics.Modelo;

namespace _01_Generics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Carro carro = new Carro()
            {
                Modelo = "Uno",
                Marca = "FIAT"
            };
            Casa casa = new Casa()
            {
                Cidade = "Brasilia",
                Endereço = "QSQ 400"
            };
            Usuario usuario = new Usuario()
            {
                Nome = "Maria",
                Email = "maria@gmail.com",
                Senha = "123456"
            };
            
            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro   carro2   = Serializador.Deserializar<Carro>();
            Casa    casa2    = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine($"Carro 2: {carro2.Marca} - {carro2.Modelo}");
            Console.WriteLine($"Casa 2: {casa2.Cidade} - {casa2.Endereço}");
            Console.WriteLine($"Usuario 2: {usuario2.Nome} - {usuario2.Email}");
            

        }
    }
}