using System;

//Create class Subject, which inherits interface IComment
public class Subject : IComment
{
    private string name;
    private byte numberLectures;
    private byte numberExercises;
    private string comment;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public byte NumberLectures
    {
        get { return this.numberLectures; }
        set { this.numberLectures = value; }
    }

    public byte NumberExercises
    {
        get { return this.numberExercises; }
        set { this.numberExercises = value; }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Subject(string name, byte numberLectures, byte numberExercises)
    {
        this.Name = name;
        this.NumberLectures = numberLectures;
        this.NumberExercises = numberExercises;
    }

    public void Print()
    {
        Console.WriteLine(this.comment);
    }

    public static Subject CreateSubject()
    {
        Console.WriteLine("Enter subject name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter number of lectures");
        byte numberLectures = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of exercises");
        byte numberExercises = byte.Parse(Console.ReadLine());
        Subject subject = new Subject(name, numberLectures, numberExercises);
        Console.WriteLine("Enter comment");
        subject.Comment = Console.ReadLine();
        return subject;
    }
}