using System;

namespace ShapeDemo
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle {Width}x{Height} with area {CalculateArea():F2}");
        }
    }
}