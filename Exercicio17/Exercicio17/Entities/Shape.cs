using Exercicio17.Entities.Enums;

namespace Exercicio17.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(){}
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
//1256