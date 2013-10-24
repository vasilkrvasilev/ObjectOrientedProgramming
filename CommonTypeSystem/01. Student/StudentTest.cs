using System;
using System.Collections.Generic;

//Uses Enumerations and class Student
public class StudentTest
{

    public static void Main()
    {
        //Enter information and create an object of class Student
        Console.WriteLine("Enter first name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter middle name");
        string middleName = Console.ReadLine();
        Console.WriteLine("Enter last name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter social security number");
        string socialSecurityNumber = Console.ReadLine();
        Console.WriteLine("Enter address");
        string address = Console.ReadLine();
        Console.WriteLine("Enter phone");
        string phone = Console.ReadLine();
        Console.WriteLine("Enter email");
        string email = Console.ReadLine();
        Console.WriteLine("Enter course");
        string course = Console.ReadLine();
        Console.WriteLine("Enter index of specialty");
        int specialty = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index of faculty");
        int faculty = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter index of university");
        int university = int.Parse(Console.ReadLine());
        Student student = new Student(firstName, middleName, lastName, socialSecurityNumber, address, phone, email,
            course, (Specialty)specialty, (Faculty)faculty, (University)university);

        //Test methods of class Student - Clone(), Equals(), ToString(), CompareTo()
        Console.WriteLine(student.ToString());
        Student clone = (Student)student.Clone();
        Console.WriteLine(clone.ToString());
        Console.WriteLine(clone.Equals(student));
        Console.WriteLine(clone.CompareTo(student));
        clone.LastName = student.MiddleName;
        Console.WriteLine("{0} {1}", clone.MiddleName, clone.LastName);
        Console.WriteLine("{0} {1}", student.MiddleName, student.LastName);
        Console.WriteLine(clone.CompareTo(student));
    }
}