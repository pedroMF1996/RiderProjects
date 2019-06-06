using herança_contrato.Enums;

namespace herança_contrato.Entities
{
    public abstract class AbstractShape:IShape
    {
        public Color Color { get; set; }
        
        public abstract double Area();
    }
}