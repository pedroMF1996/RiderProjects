using System;
using System.Globalization;
using Udemy002.Classes;

namespace Udemy002
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Produto produto;
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            
            produto = new Produto(
                nome,
                preco,
                quantidade
                );
            
            Console.WriteLine($"Dados do produto: {produto}");
            
            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);
            
            Console.WriteLine($"Dados atualizados do produto: {produto}");
            
            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);
            
            Console.WriteLine($"Dados atualizados do produto: {produto}");
        }
    }
}