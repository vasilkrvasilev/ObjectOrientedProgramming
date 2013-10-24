using System;

//Create class Student, which inherits class Human and interface IComment
public class Student : Human
{
    private byte studentNumber;

    public byte StudentNumber
    {
        get { return this.studentNumber; }
        set { this.studentNumber = value; }
    }

    public Student(string name, byte studentNumber)
        : base(name)
    {
        this.StudentNumber = studentNumber;
    }

    public static Student CreateStudent()
    {
        Console.WriteLine("Enter student name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter student number");
        byte studentNumber = byte.Parse(Console.ReadLine());
        Student student = new Student(name, studentNumber);
        Console.WriteLine("Enter comment");
        student.Comment = Console.ReadLine();
        return student;
    }
}