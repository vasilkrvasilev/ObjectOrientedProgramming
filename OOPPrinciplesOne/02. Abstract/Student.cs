using System;

//Class Student inherits abstract class Human
public class Student : Human
{
    private byte studentNumber;
    private float grade;
    private string firstName;
    private string lastName;

    public byte StudentNumber
    {
        get { return this.studentNumber; }
        set { this.studentNumber = value; }
    }

    public float Grade
    {
        get { return this.grade; }
        set 
        {
            if (value <= 6 && value >= 2)
            {
                this.grade = value;
            }
            else
            {
                throw new ArgumentException("Invalid input! You should enter grade between 2 and 6.");
            }
        }
    }

    public override string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public override string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public Student(byte studentNumber, float grade, string firstName, string lastName)
        : base()
    {
        this.StudentNumber = studentNumber;
        this.Grade = grade;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public static Student CreateStudent()
    {
        Console.WriteLine("Enter student number");
        byte studentNumber = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter student grade");
        float studentGrade = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter student first name");
        string studentFirstName = Console.ReadLine();
        Console.WriteLine("Enter last student name");
        string studentLastName = Console.ReadLine();
        Student student = new Student(studentNumber, studentGrade, studentFirstName, studentLastName);
        Console.WriteLine("Enter comment");
        student.Comment = Console.ReadLine();
        return student;
    }
}