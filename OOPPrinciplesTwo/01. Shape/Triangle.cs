using System;

//Inherits abstract class Shape and implement its properties and methods by overriding
public class Triangle : Shape
{
    private double height;
    private double width;

    public override double Height
    {
        get { return this.height; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number for height.");
            }
            this.height = value;
        }
    }

    public override double Width
    {
        get { return this.width; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number width.");
            }
            this.width = value;
        }
    }

    public Triangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override double CalculateSurface()
    {
        double area = (this.height * this.width) / 2;
        return area;
    }

    public static Triangle CreateTriangle()
    {
        Console.WriteLine("Enter height");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter width");
        double width = double.Parse(Console.ReadLine());
        Triangle triangle = new Triangle(height, width);
        return triangle;
    }
}