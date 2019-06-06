namespace Udemy011.Classes
{
    public class Rectangle:Shape
    {
        private double _width;
        private double _height;

        public double Width => _width;

        public double Height => _height;

        public Rectangle(double width, double height, Color color) : base(color)
        {
            _width = width;
            _height = height;
        }
        
        public override double area()
        {
            return (Width*Height);
        }
    }
}