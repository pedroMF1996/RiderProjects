using System.Globalization;

namespace Udemy002.Classes
{
    public class Produto
    {
        private string _Nome;
        private double _Preco;
        private int _Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _Nome = nome;
            _Preco = preco;
            _Quantidade = quantidade;
        }
        
        public Produto(string nome, double preco)
        {
            _Nome = nome;
            _Preco = preco;
            _Quantidade = 0;
        }

        public double ValorTotalEmEstoque()
        {
            return _Preco * _Quantidade;
        }

        public void AdicionarProdutos(int quant)
        {
            _Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            _Quantidade -= quant;
        }

        public override string ToString()
        {
            return $"{_Nome}, $ {_Preco.ToString("F2",CultureInfo.InvariantCulture)}, {_Quantidade.ToString()} unidade(s), Total: $ {ValorTotalEmEstoque().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}