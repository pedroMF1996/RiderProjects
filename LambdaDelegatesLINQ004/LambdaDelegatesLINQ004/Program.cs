using LambdaDelegatesLINQ004.Service;

namespace LambdaDelegatesLINQ004
{
    delegate void BinaryNumericOperation(double n1, double n2);
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * Multicast delegates:
             * .Delegates que guardam referencia para mais de um metodo
             * .Para se adcionar referencia, pode se usar o operador +=
             * .A chamada Invoke(ou sintaxe reduzida) executa todos os metodos na ordem em que foram adcionados
             * .Seu uso faz setido para metodos void
             */

            double a = 10.0f;
            double b = 12.0f;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            
            op.Invoke(a,b);


        }
    }
}