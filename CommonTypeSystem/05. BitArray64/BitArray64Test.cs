using System;
using System.Collections.Generic;
using System.Text;

//Use class BitArray64
public class BitArray64Test
{
    public static void Main()
    {
        //Create an object of class BitArray64
        Console.WriteLine("Enter length");
        int length = int.Parse(Console.ReadLine());
        BitArray64 array = new BitArray64(length);

        //Assign its elements
        Console.WriteLine("Enter elements");
        for (int count = 0; count < length; count++)
        {
            array.AddElement(uint.Parse(Console.ReadLine()));
        }

        //Test ToString() method and indexer
        Console.WriteLine(array.ToString());
        Console.WriteLine("Enter index");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine(array[index]);

        //Use foreach to test the implementation of IEnumerable<int> interface
        foreach (var item in array)
        {
            Console.Write(item);
        }
    }
}