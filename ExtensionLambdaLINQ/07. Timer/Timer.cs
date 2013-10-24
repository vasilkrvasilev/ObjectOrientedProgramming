using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Use delegates to compare strings
public delegate void Method(params string[] input);
public delegate void Method<T>(T input);

class Timer
{
    public static void Compare(params string[] array)
    {
        var sortedArray = array.OrderBy(x => x[0]);
        var sortedReverse =
            from element in array
            orderby element[element.Length - 1]
            select element;
        Console.WriteLine("Elements sorted by first char");
        foreach (var element in sortedArray)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("Elements sorted by last char");
        foreach (var element in sortedReverse)
        {
            Console.WriteLine(element);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter time interval in seconds");
        int interval = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of iterations");
        int iterations = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements");
        int number = int.Parse(Console.ReadLine());
        string[] array = new string[number];
        Console.WriteLine("Enter elements");
        for (int position = 0; position < number; position++)
        {
            array[position] = Console.ReadLine();
        }
        for (int count = 0; count < iterations; count++)
        {
            Console.WriteLine("New iteration");
            Method method = new Method(Timer.Compare);
            method(array);
            Console.WriteLine();
            Method<string[]> genericMethod = new Method<string[]>(Timer.Compare);
            genericMethod(array);
            Thread.Sleep(interval * 1000);
            Console.WriteLine();
        }
    }
}