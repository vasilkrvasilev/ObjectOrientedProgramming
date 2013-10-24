using System;

//Use classes GenericArray and GenericList
public class GrowFunction
{
    static void Main()
    {
        Console.WriteLine("Enter initial length");
        int length = int.Parse(Console.ReadLine());
        GenericList<string> sentence = new GenericList<string>(length);      //GenericList<int> array = new GenericList<int>(length);
        
        for (int count = 0; count < length; count++)
        {
            Console.WriteLine("Elements of GenericList\r\n{0}", sentence.ToString());
            Console.WriteLine("Enter element to add");
            sentence.Add(Console.ReadLine());
            Console.WriteLine("Elements of GenericList\r\n{0}", sentence.ToString());

            Console.WriteLine("Enter element to insert");
            string insertElement = Console.ReadLine();
            Console.WriteLine("Enter position");
            int insertIndex = int.Parse(Console.ReadLine());
            sentence.Insert(insertIndex, insertElement);
            Console.WriteLine("Elements of GenericList\r\n{0}", sentence.ToString());

            Console.WriteLine("The capacity of this GenericList is {0}", sentence.Length);
            Console.WriteLine("The used capacity of this GenericList is {0}", sentence.Count);
        }
    }
}