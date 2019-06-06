using System;
using Udemy008.Classes;
namespace Udemy008
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
                Account acc = new Account(1001,"Alex",0.0);
                
                BusinessAccount bacc = new BusinessAccount(1002,"Maria",0.0,500);
                
                //UPCASTING
                Account acc1 = bacc;
                Console.WriteLine(acc1);
                
                Account acc2 = new BusinessAccount(1003,"Bob",0.0,200);
                Console.WriteLine(acc2);
                
                Account acc3 = new SavingsAccount(1004,"Ana",0.0,0.01);
                Console.WriteLine(acc3);
                
                //Polimorfismo
                acc1.WithDraw(10.00);
                acc3.WithDraw(10.00);
                
                Console.WriteLine(acc1);
                Console.WriteLine(acc2);
                Console.WriteLine(acc3);
                
                //DOWNCASTING - Operação insegura
                //BusinessAccount acc4 = acc2; Da erro pois não pode converter implicitamente do menos especifico para o mais especifico
                BusinessAccount acc4 = (BusinessAccount)acc2;
                acc4.Loan(100.0);
    
                //BusinessAccount acc5 = (BusinessAccount)acc3; Embora o compilador não tenha dado nenhum erro o compilador dará um erro de tipos especificos distintos 
    
                if (acc3 is BusinessAccount)
                {
                    BusinessAccount acc5 = acc3 as BusinessAccount;
                    acc5.Loan(200.00);
                    Console.WriteLine("Loan!");
                }
    
                if (acc3 is SavingsAccount)
                {
                    SavingsAccount acc5 = acc3 as SavingsAccount;
                    acc5.UpdateBalance();
                    Console.WriteLine("Update!");
                }
            */
            
            
            
        }
    }
}