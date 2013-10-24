using System;
using System.Globalization;
using System.Threading.Tasks;

//From the book - create extension method to class String
public static class StringExtension
{
    public static string MakeCapital(this String text)
    {
        string changedText = new CultureInfo("en-US", false).TextInfo.ToTitleCase(text);
        return changedText;
    }
}

public class Extension
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        string text = Console.ReadLine();
        string changedText = text.MakeCapital();
        Console.WriteLine("The changed text is:");
        Console.WriteLine(changedText);
    }
}