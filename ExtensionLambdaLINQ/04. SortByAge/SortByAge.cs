using System;
using System.Linq;

//Use classes Student and StudentAge to create and compare different objects from class StudentAge
class SortByAge
{
    static void Main()
    {
        Console.WriteLine("Enter number of students");
        int number = int.Parse(Console.ReadLine());
        StudentAge[] array = new StudentAge[number];
        Console.WriteLine("Enter student age, first and last name separated by comma");
        for (int position = 0; position < number; position++)
        {
            string currentStudent = Console.ReadLine();
            string[] currentStudentData = currentStudent.Split(',');
            byte currentStudentAge = byte.Parse(currentStudentData[0]);
            array[position] = new StudentAge(currentStudentData[1], currentStudentData[2], currentStudentAge);
        }

        var selection =
            from student in array
            where student.Age >= 18 && student.Age <= 24
            select student;

        Console.WriteLine("Selected students are");
        foreach (var student in selection)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }
}