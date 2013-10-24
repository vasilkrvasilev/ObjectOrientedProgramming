using System;
using System.IO;
using System.Text;

//Add extention mathods to class Path
public static class PathStorage
{
    public static Path SavePath()
    {
        Console.WriteLine("Enter file name");
        string file = Console.ReadLine();
        StreamReader reader = new StreamReader(file, Encoding.GetEncoding("UTF-8"));
        using (reader)
        {
            int length = int.Parse(reader.ReadLine());
            Path path = new Path(length);
            for (int count = 0; count < length; count++)
            {
                string readPoint = reader.ReadLine();
                string[] pointCoordinates = readPoint.Split(' ');
                int abscissa = int.Parse(pointCoordinates[0]);
                int ordinate = int.Parse(pointCoordinates[1]);
                int dimension = int.Parse(pointCoordinates[2]);
                Point3D point = new Point3D(abscissa, ordinate, dimension);
                path[count] = point;
            }
            return path;
        }
    }

    public static void LoadPath(Path path)
    {
        Console.WriteLine("Enter file name");
        string file = Console.ReadLine();
        StreamWriter writer = new StreamWriter(file, true, Encoding.GetEncoding("UTF-8"));
        using (writer)
        {
            int length = path.Length;
            writer.WriteLine(length);
            for (int count = 0; count < length; count++)
            {
                Point3D point = path[count];
                int abscissa = point.Abscissa;
                int ordinate = point.Ordinate;
                int dimension = point.Dimension;
                string writtenPoint = string.Format("{0} {1} {2}", abscissa, ordinate, dimension);
                writer.WriteLine(writtenPoint);
            }
        }
    }
}