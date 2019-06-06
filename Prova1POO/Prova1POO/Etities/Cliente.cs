namespace Prova1POO.Etities
{
    public class Cliente
    {
        private double _Id;
        private string _Nome;
        private string _MetodoDePagamento;

        public double Id => _Id;

        public string Nome => _Nome;

        public string MetodoDePagamento => _MetodoDePagamento;
        
        public Cliente(double id, string nome, string metodoDePagamento)
        {
            _Id = id;
            _Nome = nome;
            _MetodoDePagamento = metodoDePagamento;
        }

        public override string ToString()
        {
            return $"Id: {Id.ToString()}, Nome: {_Nome}, Metodo de pagamento: {MetodoDePagamento}";
        }
    }
}