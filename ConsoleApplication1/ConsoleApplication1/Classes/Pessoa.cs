using System.Globalization;

namespace Classes
{
    public class Pessoa
    {
        private int _Idade;
        private string _Nome;
        private double _Peso;
        private int _RG;
        private long _CPF;

        public int Idade => _Idade;
        public string Nome => _Nome;
        public int RG => _RG;
        public long CPF => _CPF;
        public double Peso => _Peso;


        public Pessoa(string nome, int idade, int rg, long cpf, double peso)
        {
            _Nome = nome;
            _Idade = idade;
            _Peso = peso;
            _RG = rg;
            _CPF = cpf;
        }
        
        public override string ToString()
        {
            return $"Nome: {Nome} \nIdade: {Idade.ToString()} \nRG: {RG.ToString()} \nCPF: {CPF.ToString()} \nPeso: {Peso.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}