using System;

namespace ShapeDemo
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Circle with radius {Radius} and area {CalculateArea():F2}");
        }
    }
}