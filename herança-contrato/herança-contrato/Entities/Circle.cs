using System;
using System.Globalization;

namespace herança_contrato.Entities
{
    public class Circle:AbstractShape

    {
        public double Radius { get; set; }
        
        
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Circle color: {Color}, radius: {Radius.ToString("f2",CultureInfo.InvariantCulture)}, area: {Area().ToString("f2",CultureInfo.InvariantCulture)}";
        }
    }
}