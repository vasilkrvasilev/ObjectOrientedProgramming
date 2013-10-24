using System;

//Uses class Person and test its ToString() method with age equal to null and not null
public class PersonTest
{
    public static void Main()
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        Person person = new Person(name);
        Console.WriteLine(person.ToString());

        Console.WriteLine("Enter age");
        byte age = byte.Parse(Console.ReadLine());
        Person otherPerson = new Person(name, age);
        Console.WriteLine(otherPerson.ToString());
    }
}