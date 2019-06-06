using System;
using System.Globalization;

namespace Udemy010.Classes
{
    sealed class BusinessAccount: Account
    {
        private Double _loanLimit;
        
        public double LoanLimit => _loanLimit;
        
        public BusinessAccount(int number, string holder, double balance, Double loanLimit) : base(number, holder, balance)
        {
            _loanLimit = loanLimit;
        }

        public void Loan(Double amount)
        {
            _Balance -= amount;
        }
        
        public override string ToString()
        {
            return $"Number: {Number.ToString()}, "+
                   $"Holder: {Holder}, " +
                   $"Limit: $ {LoanLimit.ToString("F2",CultureInfo.InvariantCulture)}, " +
                   $"Balance: $ {Balance.ToString("F2",CultureInfo.InvariantCulture)}\n";
        }
    }
}