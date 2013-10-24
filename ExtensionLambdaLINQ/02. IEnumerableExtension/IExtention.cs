using System;
using System.Collections.Generic;

public class IExtension
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements");
        int size = int.Parse(Console.ReadLine());
        IComparable[] array = new IComparable[size];
        Console.WriteLine("Enter elements of the array");
        for (int position = 0; position < size; position++)
        {
            array[position] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum of the elements");
        Console.WriteLine(array.Sum());
        Console.WriteLine("Average of the elements");
        Console.WriteLine(array.FindAverage());
        Console.WriteLine("Product of the elements");
        Console.WriteLine(array.Multiply());
        Console.WriteLine("Max of the elements");
        Console.WriteLine(array.FindMax());
        Console.WriteLine("Min of the elements");
        Console.WriteLine(array.FindMin());
    }
}