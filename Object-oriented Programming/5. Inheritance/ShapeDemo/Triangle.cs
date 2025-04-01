using System;

namespace ShapeDemo
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"Triangle with base {Base}, height {Height} and area {CalculateArea():F2}");
        }
    }
}