using System;
using System.Globalization;

namespace Udemy010.Classes
{
    public abstract class Account
    {
        private int _Number;
        private string _Holder;
        protected Double _Balance;

        public int Number => _Number;

        public string Holder => _Holder;

        public double Balance => _Balance;

        public Account(int number,string holder,Double balance)
        {
            _Number = number;
            _Holder = holder;
            _Balance = balance;
        }

        public virtual void WithDraw(Double amount)
        {
            _Balance -= amount+5.0;
        }

        public void Deposit(Double amount)
        {
            _Balance += amount;
        }

        public override string ToString()
        {
            return $"Number: {Number.ToString()}, " +
                   $"Holder: {Holder}," +
                   $"Balance: $ {Balance.ToString("F2",CultureInfo.InvariantCulture)}\n";
        }
    }
}