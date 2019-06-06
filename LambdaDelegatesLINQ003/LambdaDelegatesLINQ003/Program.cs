using System;
using System.Globalization;
using LambdaDelegatesLINQ003.Services;

namespace LambdaDelegatesLINQ003
{
    delegate double BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Delegates
             * É uma referencia (com tipe safety) para um ou mais métodos
             *     É um tipo referencia
             *
             * Usos comuns:
             * Comunicação entre objetos de forma flexivel e estensivel (eventos/callbacks)
             * Parametrização de operações por métodos(programação funcional)
             *
             * Pré definidos
             * Action
             *
             *
             * Func
             *
             *
             * Predicate
             */
            double a = 10.0f;
            double b = 12.0f;
            
            double result0 = CalculationService.Sum(a, b);
            Console.WriteLine(result0.ToString("f2",CultureInfo.InvariantCulture));
            
            double result1 = CalculationService.Max(a, b);
            Console.WriteLine(result1.ToString("f2",CultureInfo.InvariantCulture));
            
            double result2 = CalculationService.Square(a);
            Console.WriteLine(result2.ToString("f2",CultureInfo.InvariantCulture));
            
            BinaryNumericOperation op0 = CalculationService.Sum;
            double result3 = op0(a, b);
            //double result3 = op0.Invoke(a, b);
            Console.WriteLine(result3.ToString("f2",CultureInfo.InvariantCulture));
            
            BinaryNumericOperation op1 = CalculationService.Max;
            double result4 = op1(a, b);
            Console.WriteLine(result4.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}