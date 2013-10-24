using System;
using System.Text;

//Use class GenericArray
public class ArrayFunctions
{
    static void Main()
    {
        Console.WriteLine("Enter length");
        int length = int.Parse(Console.ReadLine());
        GenericArray<string> sentence = new GenericArray<string>(length);    //GenericArray<int> array = new GenericArray<int>(length);
        Console.WriteLine("Elements of GenericArray\r\n{0}", sentence.ToString());

        Console.WriteLine("Enter element to add");
        sentence.Add(Console.ReadLine());
        Console.WriteLine("Elements of GenericArray\r\n{0}", sentence.ToString());

        Console.WriteLine("Enter element to insert");
        string insertElement = Console.ReadLine();
        Console.WriteLine("Enter position");
        int insertIndex = int.Parse(Console.ReadLine());
        sentence.Insert(insertIndex, insertElement);
        Console.WriteLine("Elements of GenericArray\r\n{0}", sentence.ToString());

        Console.WriteLine("Enter element position to be removed");
        int removeIndex = int.Parse(Console.ReadLine());
        sentence.Remove(removeIndex);
        Console.WriteLine("Elements of GenericArray\r\n{0}", sentence.ToString());

        Console.WriteLine("Enter element to find");
        string findElement = Console.ReadLine();
        Console.WriteLine("This element is on position {0}", sentence.Find(findElement));

        Console.WriteLine("Enter element position to be printed");
        int printIndex = int.Parse(Console.ReadLine());
        Console.WriteLine("The element is {0}", sentence[printIndex]);

        sentence.Clear();
        Console.WriteLine("Elements of GenericArray.Clear()\r\n{0}", sentence.ToString());
    }
}