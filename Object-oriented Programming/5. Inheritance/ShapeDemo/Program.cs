using System;

namespace ShapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(3, 8)
            };

            foreach (var shape in shapes)
            {
                shape.Display();
            }
        }
    }
}