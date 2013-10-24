using System;

//Use classes Matrix, IndexMatrix and OverloadMatrix
class OverloadOperators
{
    static void Main()
    {
        Console.WriteLine("Enter number of rows");
        int FirstRows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int firstColumns = int.Parse(Console.ReadLine());
        OverloadMatrix<int> firstMatrix = new OverloadMatrix<int>(FirstRows, firstColumns);
        Console.WriteLine("Enter elements");
        for (int row = 0; row < FirstRows; row++)
        {
            for (int column = 0; column < firstColumns; column++)
            {
                firstMatrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter number of rows");
        int secondRows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of columns");
        int secondColumns = int.Parse(Console.ReadLine());
        OverloadMatrix<int> secondMatrix = new OverloadMatrix<int>(secondRows, secondColumns);
        Console.WriteLine("Enter elements");
        for (int row = 0; row < secondRows; row++)
        {
            for (int column = 0; column < secondColumns; column++)
            {
                secondMatrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        OverloadMatrix<int> sum = firstMatrix + secondMatrix;
        OverloadMatrix<int> subtract = firstMatrix - secondMatrix;
        OverloadMatrix<int> multiply = firstMatrix * secondMatrix;
        Console.WriteLine("The sum of two matrices is");
        for (int row = 0; row < sum.Hight; row++)
        {
            for (int column = 0; column < sum.Width; column++)
            {
                Console.Write("{0} ", sum[row, column]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("The subtraction of two matrices is");
        for (int row = 0; row < subtract.Hight; row++)
        {
            for (int column = 0; column < subtract.Width; column++)
            {
                Console.Write("{0} ", subtract[row, column]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("The product of two matrices is");
        for (int row = 0; row < multiply.Hight; row++)
        {
            for (int column = 0; column < multiply.Width; column++)
            {
                Console.Write("{0} ", multiply[row, column]);
            }
            Console.WriteLine();
        }

        if (firstMatrix)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}