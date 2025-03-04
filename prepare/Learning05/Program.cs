using System;

class Program
{
    static void Main(string[] args)
    {
        // Displays color and area of a square
        // First parameter: color
        // Second paramter: length of side (named 'side' in code)
        Square square1 = new Square("red", 10);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        // Displays color and area of a rectangle
        // First parameter: color
        // Second parameter: length
        // Third parameter: width
        Rectangle rectangle1 = new Rectangle("yellow", 20, 20);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        // Displays color and area of a circle
        // First parameter: color
        // Second parameter: radius
        Circle circle1 = new Circle("blue", 20);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        Console.WriteLine("The following is the printed list: ");

        List<Shape> shapes1 = new List<Shape>();
        shapes1.Add(square1);
        shapes1.Add(rectangle1);
        shapes1.Add(circle1);

        foreach (Shape shape in shapes1)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }

    }
}