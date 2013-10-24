using System;

//Create class Teacher, which inherits class Human and interface IComment
public class Teacher : Human
{
    private Subject[] subjects;

    public Subject[] Subjects
    {
        get { return this.subjects; }
        set { this.subjects = value; }
    }

    public Teacher(string name, Subject[] subjects)
        : base(name)
    {
        this.Subjects = subjects;
    }

    public static Teacher CreateTeacher(Subject[] subjects)
    {
        Console.WriteLine("Enter teacher name");
        string name = Console.ReadLine();
        Teacher teacher = new Teacher(name, subjects);
        Console.WriteLine("Enter comment");
        teacher.Comment = Console.ReadLine();
        return teacher;
    }
}