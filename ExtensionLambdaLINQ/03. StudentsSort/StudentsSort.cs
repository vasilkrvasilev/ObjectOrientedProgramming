using System;
using System.Linq;

//Use class Student to create and compare different objects from class Student
public class StudentsSort
{
    static void Main()
    {
        Console.WriteLine("Enter number of students");
        int number = int.Parse(Console.ReadLine());
        Student[] array = new Student[number];
        Console.WriteLine("Enter student first and last name separated by comma");
        for (int position = 0; position < number; position++)
        {
            string currentStudent = Console.ReadLine();
            string[] currentStudentNames = currentStudent.Split(',');
            array[position] = new Student(currentStudentNames[0], currentStudentNames[1]);
        }

        var selection =
            from student in array
            where student.FirstName.CompareTo(student.LastName) < 0
            select student;

        Console.WriteLine("Selected students are");
        foreach (var student in selection)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}