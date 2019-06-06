using System.Collections.Generic;
using System.Globalization;

namespace Prova1POO.Etities
{
    public class Carrinho
    {
        private int _Id;
        private List<Produto> _Produtos = new List<Produto>();
        private Cliente _Cliente;
        
        public List<Produto> Produtos => _Produtos;

        public Cliente Cliente => _Cliente;

        public int Id => _Id;


        public Carrinho(int id, Cliente cliente)
        {
            _Id = id;
            _Cliente = cliente;
        }

        public void Comprar(Produto prod)
        {
            _Produtos.Add(prod);
        }

        public void RemoverItem(Produto prod)
        {
            foreach (Produto x in Produtos)
            {
                if (x == prod)
                {
                    _Produtos.Remove(prod);
                }
            }
        }

        private double? Total()
        {
            double sum = 0.0f;
            if (Produtos != null)
            {
                foreach (Produto x in Produtos)
                {
                    sum += x.Preco;
                }
            }

            return sum;
        }

        public override string ToString()
        {
            string r = $"Id: {Id.ToString()} \nCliente: {Cliente}, Metodo de pagamento: {Cliente.MetodoDePagamento}\n";
            if (Produtos != null)
            {
                r += "Produtos comprados: \n";
                foreach (Produto x in Produtos)
                {
                    r += $"Id: {x.Id.ToString()}, Nome: {x.Nome}, Preco: $ {x.Preco.ToString("F2",CultureInfo.InvariantCulture)}\n";
                }

                r += $"Total da compra: {Total().ToString()}";
            }

            return r;
        }
    }
}