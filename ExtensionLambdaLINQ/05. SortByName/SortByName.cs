using System;
using System.Linq;

//Use class Student to create and compare different objects from class Student
class SortByName
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

        var sortedArray = array.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
        Console.WriteLine("Sorted students with lambda expression");
        foreach (var student in sortedArray)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }

        var sortedStudents =
            from student in array
            orderby student.LastName descending
            orderby student.FirstName descending
            select student;

        Console.WriteLine("Sorted students with LINQ query");
        foreach (var student in sortedStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}