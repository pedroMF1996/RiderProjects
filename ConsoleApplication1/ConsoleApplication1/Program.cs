using System;
using Classes;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void ReplicaMensagem(string frase, int cont)
        {
            while (cont>0)
            {
                EscreveNaTela(frase:frase);
                cont--;
            }
        }
        public static void EscreveNaTela(string frase)
        {
            Pessoa pessoa;
            pessoa = new Pessoa(
                nome:"Pedro Martins Falleiros",
                idade:22,
                rg:525077510,
                cpf:47560841848,
                peso:90.00
            );
            Console.WriteLine(frase + $"\nVocê é: {pessoa}");
        }

        public static void EscrevaUmaMensagem(string frase)
        {
            ReplicaMensagem(frase:"O que você escreveu foi: "+frase,1);
        }
        
        public static void Main(string[] args)
        {
            EscrevaUmaMensagem(Console.ReadLine());
        }
    }
}