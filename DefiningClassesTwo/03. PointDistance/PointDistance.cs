using System;

//Use classes Point3D and Distance
class PointDistance
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
        Point3D coordinateSystemCenter = Point3D.PointO;
        Console.WriteLine(coordinateSystemCenter.ToString());
        double distance = Distance.CalculateDiscance(point, coordinateSystemCenter);
        Console.WriteLine("The distance between the point and the center of the coordinate system is\r\n\t{0:F2} cm", distance);
    }
}