using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Usuario> usuario = new List<Usuario>();

            usuario.Add(new Usuario() {Nome = "José",   email = "jose@gmail.com"});
            usuario.Add(new Usuario() {Nome = "Maria",  email = "maria@hotmail.com"});
            usuario.Add(new Usuario() {Nome = "João",   email = "joao@yahoo.com"});
            usuario.Add(new Usuario() {Nome = "Felipe", email = "felipe@ig.com"});
            usuario.Add(new Usuario() {Nome = "Elias",  email = "elias@gmail.com"});

            var lista_filtrada = from a in usuario
                where a.email.Contains("@gmail.com")
                orderby a.Nome
                select a.Nome;
            
            foreach (var item in lista_filtrada)
            {
                Console.WriteLine(item);
            }
        }
    }
}