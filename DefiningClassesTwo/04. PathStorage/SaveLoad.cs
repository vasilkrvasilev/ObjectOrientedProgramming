using System;

//Use classes Point3D, Path and PathStorage
class SaveLoad
{
    static void Main()
    {
        Console.WriteLine("Enter number of points");
        int length = int.Parse(Console.ReadLine());
        Path path = new Path(length);
        for (int count = 0; count < length; count++)
        {
            Console.WriteLine("Enter point abscissa");
            int abscissa = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter point ordinate");
            int ordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter point dimension");
            int dimension = int.Parse(Console.ReadLine());
            Point3D point = new Point3D(abscissa, ordinate, dimension);
            path[count] = point;
        }

        PathStorage.LoadPath(path);
        Path savedPath = PathStorage.SavePath();
        for (int count = 0; count < length; count++)
        {
            Console.WriteLine(savedPath[count].ToString());
        }
    }
}