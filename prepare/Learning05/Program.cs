using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 15);
        // Console.WriteLine($"The square is {square.GetColor()} with an area of {square.GetArea()}");

        Rectangle rectangle = new Rectangle("red", 10, 3);
        // Console.WriteLine($"The rectangle is {rectangle.GetColor()} with an area of {rectangle.GetArea()}");

        Circle circle = new Circle("yellow", 13);
        // Console.WriteLine($"The circle is {circle.GetColor()} with an area of {circle.GetArea()}");

        List<Shape> shapes = new List<Shape> 
        {
            square, rectangle, circle
        };

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}