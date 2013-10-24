using System;

//Create abstract class Shape
public abstract class Shape
{
    public abstract double Height { get; set; }
    public abstract double Width { get; set; }

    public abstract double CalculateSurface();
}