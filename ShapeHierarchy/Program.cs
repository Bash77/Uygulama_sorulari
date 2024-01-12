using System;

// Abstract base class
public abstract class Shape
{
    // Virtual method for calculating area
    public abstract double Area();
}

// Derived class for Rectangle
public class Rectangle : Shape
{
    // Properties for length and width
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Override the Area method for Rectangle
    public override double Area()
    {
        return Length * Width;
    }
}

// Derived class for Circle
public class Circle : Shape
{
    // Property for radius
    public double Radius { get; set; }

    // Constructor
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Override the Area method for Circle
    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Program
{
    // Method to display the area of any Shape object
    static void DisplayArea(Shape shape)
    {
        Console.WriteLine($"Area of the shape: {shape.Area()}");
    }

    static void Main()
    {
        // Example usage:
        Rectangle rectangle = new Rectangle(4.0, 5.0);
        Circle circle = new Circle(3.0);

        DisplayArea(rectangle); // Display area of the rectangle
        DisplayArea(circle);    // Display area of the circle

        Console.ReadLine();
    }
}
