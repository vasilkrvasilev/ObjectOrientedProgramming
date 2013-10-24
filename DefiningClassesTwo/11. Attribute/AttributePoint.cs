using System;
using System.Reflection;
using System.Runtime.InteropServices;

//Use class Point3D

[Version(1, 0)]                                                                    //Use attribute Version to class AttributePoint
class AttributePoint
{
    static void Main()
    {
        Type type = typeof(AttributePoint);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (Version attribute in attributes)                                 //Write current version on the console
        {
            Console.WriteLine("Version {0}.{1}", attribute.Major, attribute.Minor);
        }
        Console.WriteLine("This is the class AttributePoint");
        PrintPoint();                                                             //Some method
    }

    [Version(1, 1)]                                                               //Use attribute Version to method PrintPoint()
    public static void PrintPoint()
    {
        Type type = typeof(AttributePoint);
        MethodInfo[] methods = type.GetMethods();
        object[] methodAttributes = methods[0].GetCustomAttributes(false);       //First method is PrintPoint(), rest are TOString()...
        foreach (var attribute in methodAttributes)                              //Write current version on the console
        {
            Console.WriteLine("Version {0}.{1}", (attribute as Version).Major, (attribute as Version).Minor);
        }
        Console.WriteLine("This is the method PrintPoint()");
        Console.WriteLine("Enter point abscissa");
        int abscissa = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter point ordinate");
        int ordinate = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter point dimension");
        int dimension = int.Parse(Console.ReadLine());
        Point3D point = new Point3D(abscissa, ordinate, dimension);
        Console.WriteLine(point.ToString());
    }
}