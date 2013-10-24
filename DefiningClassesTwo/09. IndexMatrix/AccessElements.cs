using System;

//Use classes Matrix and IndexMatrix
public class AccessElements
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int columns = int.Parse(Console.ReadLine());
        IndexMatrix<int> matrix = new IndexMatrix<int>(rows, columns);

        Console.WriteLine("Enter elements");
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                matrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter row");
        int elementRow = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter column");
        int elementColumn = int.Parse(Console.ReadLine());
        Console.WriteLine("Element on position [{0}, {1}] has value {2}", 
            elementRow, elementColumn, matrix[elementRow, elementColumn]);
    }
}