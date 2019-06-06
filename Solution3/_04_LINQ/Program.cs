using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LINQ
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Autor1 = new Autor(){Id = 1,Nome = "Leandro"};
            var Autor2 = new Autor(){Id = 2,Nome = "Maria"};
            var Autor3 = new Autor(){Id = 3,Nome = "Joseph"};
            List<Autor> autores = new List<Autor>(){Autor1,Autor2,Autor3};
            
            var Livro1 = new Livro(){Id = 1,AutorId = 2,Titulo = "Amor Amado"};
            var Livro2 = new Livro(){Id = 2,AutorId = 2,Titulo = "Bem amado"};
            var Livro3 = new Livro(){Id = 3,AutorId = 3,Titulo = "Um espião em Washington D.C."};
            var Livro4 = new Livro(){Id = 4,AutorId = 1,Titulo = "Vida na terra"};
            List<Livro> livros = new List<Livro>(){Livro1,Livro2,Livro3,Livro4};

//            var ListaJoin = from a in autores
//                join l in livros on a.Id equals l.AutorId  
//                select $"{a.Nome}: {l.Titulo }";
//            
            var ListaJoin = from a in autores
                join l in livros on a.Id equals l.AutorId
                select new { a, l};

            
            foreach (var item in ListaJoin)
            {
                Console.WriteLine($"Livro: {item.a.Nome} - Autor {item.l.Titulo}");    
            }
        }
    }
}