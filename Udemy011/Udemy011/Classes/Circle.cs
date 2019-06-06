using System;

namespace Udemy011.Classes
{
    public class Circle:Shape
    {
        private double _radious;

        public double Radious => _radious;

        public Circle(double radious, Color color) : base(color)
        {
            _radious = radious;
        }
        
        public override double area()
        {
            return 2 * Math.PI * Radious;
        }
    }
}