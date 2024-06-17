using System;

public abstract class Shape
{
    public abstract double GetArea();
}


public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea()
    {
        return Length * Breadth;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle1 = new Circle(4.5);
        Shape rectangle1 = new Rectangle(4, 3);

        Console.WriteLine("Area of circle : " + circle1.GetArea());
        Console.WriteLine("Area of rectangle : " + rectangle1.GetArea());
    }
}


