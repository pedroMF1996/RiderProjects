using System;
using System.Globalization;

namespace Udemy010.Classes
{
    sealed class SavingsAccount : Account
    {
        private Double _InterestRate;

        public double InterestRate => _InterestRate;
        
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            _InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            _Balance+=(_Balance*InterestRate);
        }
        
        public sealed override void WithDraw(double amount)
        {
            base.WithDraw(amount);
            _Balance -= 2.00;
        }
        
        public override string ToString()
        {
            return $"Number: {Number.ToString()}, " +
                   $"Holder:  {Holder}, " +
                   $"Balance: $ {Balance.ToString("F2",CultureInfo.InvariantCulture)},  " +
                   $"Iterest rate: % {(InterestRate*100).ToString("F2", CultureInfo.InvariantCulture)}\n";
        }
    }
}