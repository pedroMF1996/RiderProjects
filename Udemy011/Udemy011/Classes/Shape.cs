namespace Udemy011.Classes
{
    public abstract class Shape
    {
        private Color _color;

        public Color Color => _color;

        public Shape(Color color)
        {
            _color = color;
        }

        public abstract double area();

    }
}