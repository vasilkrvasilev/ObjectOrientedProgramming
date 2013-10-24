using System;
using System.Collections.Generic;
using System.Linq;

class DevideThreeSeven
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements");
        int number = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        Console.WriteLine("Enter elements of the array");
        for (int position = 0; position < number; position++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        var selectedNumbers = array.FindAll((x) => ((x % 3 == 0) || (x % 7 == 0)));
        Console.WriteLine("Selected numbers with lambda expression");
        foreach (var item in selectedNumbers)
        {
            Console.WriteLine(item);
        }

        var selection =
            from element in array
            where (element % 3 == 0) || (element % 7 == 0)
            select element;

        Console.WriteLine("Selected numbers with LINQ query");
        foreach (var element in selection)
        {
            Console.WriteLine(element);
        }
    }
}