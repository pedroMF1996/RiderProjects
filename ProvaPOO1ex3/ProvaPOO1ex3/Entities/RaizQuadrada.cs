using System;

namespace ProvaPOO1ex3.Entities
{
    public abstract class RaizQuadrada
    {

        public static double PrimeiraAprox(double Y)
        {
            return Y / 2;
        }

        public static double AproxSubSeq(double xn, double y )
        {
            return ((Math.Pow(xn, 2)+y) / (2 * xn));
        }
        
    }
}