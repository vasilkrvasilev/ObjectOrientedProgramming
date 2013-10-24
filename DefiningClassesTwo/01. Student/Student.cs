using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//From the book - create class Student, use enumerations Course, University, Major
public class Student
{
    private string email;
    private Course course;
    private string firstName;
    private string middleName;
    private string lastName;
    private University university;
    private Major major;
    private string phone;
    private static int count = 0;
    private static List<Student> studentList = new List<Student>();

    public static List<Student> StudentList
    {
        get { return studentList; }
    }

    public static int Count
    {
        get { return count; }
    }

    public string Email
    {
        get { return this.email; }
        set
        {
            MatchCollection check = Regex.Matches(value, @"\w+@\w+\.\w+");
            if (check.Count == 1)
            {
                this.email = value;
            }
            else
            {
                throw new ArgumentException("Invalid input! You enter invalid email address.");
            }
        }
    }

    public Course Course
    {
        get { return this.course; }
        set
        {
            if ((byte)this.course > 4)
            {
                throw new ArgumentException("Invalid input! You should enter number between 0 and 4.");
            }
            this.course = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string MiddleName
    {
        get { return this.middleName; }
        set { this.middleName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public University University
    {
        get { return this.university; }
        set
        {
            if ((byte)this.university > 4)
            {
                throw new ArgumentException("Invalid input! You should enter number between 0 and 4.");
            }
            this.university = value;
        }
    }

    public Major Major
    {
        get { return this.major; }
        set
        {
            if ((byte)this.major > 4)
            {
                throw new ArgumentException("Invalid input! You should enter number between 0 and 4.");
            }
            this.major = value;
        }
    }

    public string Phone
    {
        get { return this.phone; }
        set { this.phone = value; }
    }

    public Student(string email, Course course)
    {
        this.Email = email;
        this.Course = course;
        count++;
    }

    public Student(string email, Course course, string firstName, string middleName, string lastName)
        : this(email, course)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        count++;
    }

    public Student(string email, Course course, string firstName, string middleName, string lastName,
        University university, Major major)
        : this(email, course, firstName, middleName, lastName)
    {
        this.University = university;
        this.Major = major;
        count++;
    }

    public Student(string email, Course course, string firstName, string middleName, string lastName,
        University university, Major major, string phone)
        : this(email, course, firstName, middleName, lastName, university, major)
    {
        this.Phone = phone;
        count++;
    }

    public void Print()
    {
        Console.WriteLine(
            "Student {0} {1} {2}, with email {3}\r\nenrolled on {4} course\r\nuniversity {5}, major {6}\r\nphone {7}",
            this.FirstName, this.MiddleName, this.LastName, this.Email, this.Course,
            this.University, this.Major, this.Phone);
    }

    public static Student CreateStudent()
    {
        Console.WriteLine("Enter email");
        string studentEmail = Console.ReadLine();
        Console.WriteLine("Enter course code");
        byte studentCourse = byte.Parse(Console.ReadLine());
        Student student = new Student(studentEmail, (Course)studentCourse);
        StudentList.Add(student);
        return student;
    }

    public Student this[int index]
    {
        get { return StudentList[index]; }
    }
}