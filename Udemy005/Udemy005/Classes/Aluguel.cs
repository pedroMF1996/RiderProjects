using System;
using System.Collections;

namespace Udemy005.Classes
{
    public class Aluguel:IComparable
    {
        private string _Nome;
        private string _Email;
        private int _Quarto;

        public Aluguel(string nome,string email,int quarto)
        {
            _Nome = nome;
            _Email = email;
            _Quarto = quarto;
        }

        public override string ToString()
        {
            return $"{_Quarto.ToString()}: {_Nome}, {_Email}";
        }

        public int CompareTo(object obj)
        {
            Aluguel outro = (Aluguel) obj;
            return _Quarto.CompareTo(outro._Quarto);
        }
    }
}