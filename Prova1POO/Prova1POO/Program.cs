using System;
using System.Globalization;
using Prova1POO.Etities;
using Prova1POO.Etities.DomainEsception;

namespace Prova1POO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados do cliente: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Id: ");
                int id = Int32.Parse(Console.ReadLine() ?? throw new DomeinException("Dados não identificados"));
                Console.Write("Metodo de pagamento: ");
                string mtdPagamento = Console.ReadLine();
                
                Cliente cliente = new Cliente(id,nome,mtdPagamento);
                Console.WriteLine("Entre comos dados da compra: ");
                Console.Write("\n Quantos itens foram comprados? ");
                
                Carrinho carrinho = new Carrinho(id, cliente);
                int qtd = Int32.Parse(Console.ReadLine()?? throw new DomeinException("Dados não identificados"));
                for (int i = 0; i < qtd; i++)
                {
                    Console.Write($"Id do produto {(i+1).ToString()}: ");
                    int idp = Int32.Parse(Console.ReadLine()??throw new DomeinException("Id não identificado"));
                    Console.Write($"Nome do produto {(i+1).ToString()}: ");
                    string nomep = Console.ReadLine();
                    Console.Write($"Preco do produto {(i+1).ToString()}: ");
                    double preco = Double.Parse(Console.ReadLine()?? throw new DomeinException("Preco nao identificado"));
                    
                    carrinho.Comprar(new Produto(nomep,preco,idp));
                }

                if (carrinho.Produtos.Count>0)
                {
                    Console.WriteLine("Compra realizada com sucesso: ");
                    Console.WriteLine(carrinho);
                }
                else
                {
                    Console.WriteLine("cancelamento efetuado com sucesso!");
                }
            }
            catch (DomeinException e)
            {
                Console.WriteLine($"Error: {e.Message} \nSource: {e.Source}");
            }
            
            
            
        }
    }
}