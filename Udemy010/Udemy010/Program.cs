using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy010.Classes;

namespace Udemy010
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Account acc1 = new Account(1001,"Alex", 500.00);
            Account acc2 = new SavingsAccount(1002,"Anna", 500.00, 0.01);
            
            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
            
            */
            
            List<Account> accounts = new List<Account>();
            accounts.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1002,"Maria", 500.00,400.00));
            accounts.Add(new SavingsAccount(1003,"Bob", 500.00,0.01));
            accounts.Add(new BusinessAccount(1004,"Anna", 500.00,500.00));

            double sum = 0.0f;
            foreach (Account x in accounts)
            {
                sum += x.Balance;
            }

            Console.WriteLine($"Total balance: $ {sum.ToString("f2",CultureInfo.InvariantCulture)}\n");
            foreach (Account x in accounts)
            {
                x.WithDraw(10.00);
            }

            foreach (Account x in accounts)
            {
                Console.WriteLine(x);
            }
        }
    }
}