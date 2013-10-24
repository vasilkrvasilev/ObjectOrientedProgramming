using System;
using System.Collections.Generic;
using System.Text;

//Use classes GenericArray, GenericList and ComparableList
class MinMax
{
    static void Main()
    {
        Console.WriteLine("Enter initial length");
        int length = int.Parse(Console.ReadLine());
        ComparableList<string> sentence = new ComparableList<string>(length);      //ComparableList<int> sentence = new ComparableList<int>(length);
        Console.WriteLine("Elements of ComparableList\r\n{0}", sentence.ToString());

        for (int count = 0; count < length; count++)
        {
            Console.WriteLine("Enter element to add");
            sentence.Add(Console.ReadLine());
            Console.WriteLine("Elements of ComparableList\r\n{0}", sentence.ToString());
        }

        Console.WriteLine("Enter element to insert");
        string insertElement = Console.ReadLine();
        Console.WriteLine("Enter position");
        int insertIndex = int.Parse(Console.ReadLine());
        sentence.Insert(insertIndex, insertElement);
        Console.WriteLine("Elements of ComparableList\r\n{0}", sentence.ToString());

        string min = sentence[0];
        string max = sentence[0];
        for (int position = 1; position < sentence.Count; position++)
        {
            min = sentence.Min(min, sentence[position]);
            max = sentence.Max(max, sentence[position]);
        }

        Console.WriteLine("The min element in ComparableList is {0}", min);
        Console.WriteLine("The max element in ComparableList is {0}", max);
    }
}