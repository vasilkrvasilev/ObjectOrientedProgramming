using System;
using System.Text;

public static class StringBuilderExtension
{
    public static StringBuilder Substring(this StringBuilder text, int index, int length)
    {
        string stringText = text.ToString();
        string substring = stringText.Substring(index, length);
        StringBuilder stringBuilderSubstring = new StringBuilder();
        stringBuilderSubstring.Append(substring);
        return stringBuilderSubstring;
    }
}

public class Extension
{
    static void Main()
    {
        Console.WriteLine("Enter text");
        StringBuilder text = new StringBuilder();
        text.Append(Console.ReadLine());
        Console.WriteLine("Enter start index and length of the substring");
        int index = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("The substring is:");
        Console.WriteLine(text.Substring(index, length));
    }
}