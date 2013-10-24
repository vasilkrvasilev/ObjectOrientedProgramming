using System;

//Use class Matrix
public class CreateMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int columns = int.Parse(Console.ReadLine());
        Matrix<int> matrix = new Matrix<int>(rows, columns);
        Console.WriteLine("Matrix info - hight, width, entered numbers");
        Console.WriteLine(matrix.Hight);
        Console.WriteLine(matrix.Width);
        Console.WriteLine(matrix.Count);
    }
}