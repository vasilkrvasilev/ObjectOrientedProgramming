using System;
using System.Collections.Generic;
using System.Linq;

//Define abstract class Human with first name and last name. Define new class Student 
//which is derived from Human and has new field – grade. Define class Worker derived from Human 
//with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
//Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students 
//and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
//Initialize a list of 10 workers and sort them by money per hour in descending order. 
//Merge the lists and sort them by first name and last name.

class Abstract
{
    static void Main()
    {
        int number = 10;
        //second way
        //Console.WriteLine("Enter number");
        //int number = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();
        List<Worker> workers = new List<Worker>();

        //Create students
        for (int count = 0; count < number; count++)
        {
            Student currentStudent = Student.CreateStudent();
            students.Add(currentStudent);
        }

        //Create workers
        for (int count = 0; count < number; count++)
        {
            Worker currentWorker = Worker.CreateWorker();
            workers.Add(currentWorker);
        }

        //Sort students
        var sortedStudents =
            from element in students
            orderby element.Grade ascending
            select element;
        foreach (var element in sortedStudents)
        {
            Console.WriteLine("Student {0} {1} with number {2} - grade {3}",
                element.FirstName, element.LastName, element.StudentNumber, element.Grade);
        }

        //Sort workers
        var sortedWorkers =
            from element in workers
            orderby element.MoneyPerHour() descending
            select element;
        foreach (var element in sortedWorkers)
        {
            Console.WriteLine("Worker {0} {1} - salary per hour {2:F2}", element.FirstName, element.LastName, element.MoneyPerHour());
        }

        //second way of sorting
        //var sortedStudents = students.OrderBy(x => x.Grade);
        //var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

        //Join students and workers in a list of humans
        List<Human> humans = new List<Human>();
        for (int count = 0; count < number; count++)
        {
            Human currentHuman = (Human)students[count];
            humans.Add(currentHuman);
        }

        for (int count = 0; count < number; count++)
        {
            Human currentHuman = (Human)workers[count];
            humans.Add(currentHuman);
        }

        //Sort humans
        var sortedHumans =
            from element in humans
            orderby element.LastName ascending
            orderby element.FirstName ascending
            select element;
        foreach (var element in sortedHumans)
        {
            Console.WriteLine("Name {0} {1}", element.FirstName, element.LastName);
        }

        //second way of sorting
        //var sortedHuman = students.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);
    }
}