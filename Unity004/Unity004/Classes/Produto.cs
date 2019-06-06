using System.Globalization;

namespace Unity004.Classes
{
    public class Produto
    {
        private string _Nome;
        private double _Preco;

        public Produto(string nome, double preco)
        {
            _Nome = nome;
            _Preco = preco;
        }

        public double Preco => _Preco;

        public override string ToString()
        {
            return $"{_Nome}, $ {_Preco.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}