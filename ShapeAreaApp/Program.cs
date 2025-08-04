using System;

namespace ShapeAreaApp
{
    // Abstract base class
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class: Circle
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Main program
    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5.0);
            Shape rectangle = new Rectangle(4.0, 6.0);

            Console.WriteLine($"Area of the circle: {circle.GetArea():F2}");
            Console.WriteLine($"Area of the rectangle: {rectangle.GetArea():F2}");
        }
    }
}
