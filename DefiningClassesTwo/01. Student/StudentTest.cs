using System;
using System.Collections.Generic;

//Use class Student and enumerations Course, University, Major
public class StudentTest
{
    static void Main()
    {
        Console.WriteLine("Enter number of new students");
        int number = int.Parse(Console.ReadLine());
        for (int count = 0; count < number; count++)
        {
            Student currentStudent = Student.CreateStudent();
        }

        Console.WriteLine("Number of students is {0}", Student.Count);

        Console.WriteLine("Enter index of student");
        int index = int.Parse(Console.ReadLine());
        Student.StudentList[index].Print();
    }
}