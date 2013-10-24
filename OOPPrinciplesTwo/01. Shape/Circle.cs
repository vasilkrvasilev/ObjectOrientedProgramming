using System;

//Inherits abstract class Shape and implement its properties and methods by overriding
//Define new property Raduis, which is used in the constuctor and replaces properties Height and Width
public class Circle : Shape
{
    private double height;
    private double width;
    private double radius;

    public double Radius
    {
        get { return this.radius; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number for radius.");
            }
            this.radius = value;
        }
    }

    public override double Height
    {
        get { return this.radius; }
        set { this.height = this.radius; }
    }

    public override double Width
    {
        get { return this.radius; }
        set { this.width = this.radius; }
    }

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public override double CalculateSurface()
    {
        double area = Math.PI * this.radius * this.radius;
        return area;
    }

    public static Circle CreateCircle()
    {
        Console.WriteLine("Enter radius");
        double radius = double.Parse(Console.ReadLine());
        Circle circle = new Circle(radius);
        return circle;
    }
}