using System;

//Create class Class, which inherits interface IComment
public class Class : IComment
{
    private string identifier;
    private Teacher[] classTeachers;
    private string comment;

    public string Identifier
    {
        get { return this.identifier; }
        set { this.identifier = value; }
    }

    public Teacher[] ClassTeachers
    {
        get { return this.classTeachers; }
        set { this.classTeachers = value; }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Class(string identifier, Teacher[] classTeachers)
    {
        this.Identifier = identifier;
        this.ClassTeachers = classTeachers;
    }

    public void Print()
    {
        Console.WriteLine(this.comment);
    }

    public static Class CreateClass(Teacher[] teachers)
    {
        Console.WriteLine("Enter class identifier");
        string identifier = Console.ReadLine();
        Class currentClass = new Class(identifier, teachers);
        Console.WriteLine("Enter comment");
        currentClass.Comment = Console.ReadLine();
        return currentClass;
    }
}