using System;

//Use class Point3D
class PointO
{
    static void Main()
    {
        Console.WriteLine("Enter point abscissa");
        int abscissa = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter point ordinate");
        int ordinate = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter point dimension");
        int dimension = int.Parse(Console.ReadLine());
        Point3D point = new Point3D(abscissa, ordinate, dimension);
        Console.WriteLine(point.ToString());
        Point3D CoordinateSystemCenter = Point3D.PointO;
        Console.WriteLine(CoordinateSystemCenter.ToString()); 
    }
}