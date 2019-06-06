namespace Prova1POO.Etities
{
    public class Produto
    {
        private int _Id;
        private string _Nome;
        private double _Preco;

        public string Nome => _Nome;

        public double Preco => _Preco;

        public int Id => _Id;
        
        public Produto(string nome, double preco, int Id)
        {
            _Nome = nome;
            _Preco = preco;
            _Id = Id;
        }
        
        
    }
}