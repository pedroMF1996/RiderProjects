using System;

namespace Udemy001.ClaseTriangulos
{
    public class Triangulo
    {
        private double _xA;
        private double _xB;
        private double _xC;

        public Triangulo(double xa, double xb, double xc)
        {
            _xA = xa;
            _xB = xb;
            _xC = xc;
        }

        public double Perimetro()
        {
            double perimetro = 0.0f;

            perimetro = (_xA + _xB + _xC)/2; 
            
            return perimetro;
        }
        
        public double Area()
        {
            double p = Perimetro();

            return Math.Sqrt(p * (p - _xA) * (p - _xB) * (p - _xC));
        }
    }
}