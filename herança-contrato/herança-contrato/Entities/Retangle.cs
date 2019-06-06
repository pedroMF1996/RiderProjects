using System.Globalization;

namespace herança_contrato.Entities
{
    public class Retangle:AbstractShape
    {
        public double widht { get; set; }
        public double height { get; set; }
        
        public override double Area()
        {
            return widht * height;
        }

        public override string ToString()
        {
            return $"Rectangle color = {Color}, " +
                   $"widht: {widht.ToString("f2",CultureInfo.InvariantCulture)}, " +
                   $"height: {height.ToString("f2",CultureInfo.InvariantCulture)}, " +
                   $"area: {Area().ToString("f2",CultureInfo.InvariantCulture)} ";
        }
    }
}