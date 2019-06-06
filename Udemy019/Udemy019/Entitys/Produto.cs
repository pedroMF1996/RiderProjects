namespace Udemy019.Entitys
{
    public class Produto
    {
        private string _nome;
        private double _price;
        private int _quantidade;

        public string Nome => _nome;

        public double Price => _price;

        public int Quantidade => _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _price = preco;
            _quantidade = quantidade;
        }

        public double Total()
        {
            return Quantidade * Price;
        }
    }
}