using System;

//We are given a school. In the school there are classes of students. Each class has a set of teachers. 
//Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. 
//Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. 
//Students, classes, teachers and disciplines could have optional comments (free text block).
//Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, 
//define the class hierarchy and create a class diagram with Visual Studio.

//Use classes Student, Teacher, Subject, Class and School (interface IComment, class Human)
public class CreateSchool
{
    static void Main()
    {
        //Create subjects
        Console.WriteLine("Enter number of all subjects");
        int numberSubjects = int.Parse(Console.ReadLine());
        Subject[] subjects = new Subject[numberSubjects];
        for (int count = 0; count < numberSubjects; count++)
        {
            subjects[count] = Subject.CreateSubject();
        }

        //Create students
        Console.WriteLine("Enter number of students");
        int numberStudents = int.Parse(Console.ReadLine());
        Student[] students = new Student[numberSubjects];
        for (int count = 0; count < numberStudents; count++)
        {
            students[count] = Student.CreateStudent();
        }

        //Create teachers
        Console.WriteLine("Enter number of teachers");
        int numberTeachers = int.Parse(Console.ReadLine());
        Teacher[] teachers = new Teacher[numberSubjects];
        for (int count = 0; count < numberStudents; count++)
        {
            Console.WriteLine("Enter number of teacher's subjects");
            int numberTeacherSubjects = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject names");
            Subject[] teacherSubjects = new Subject[numberTeacherSubjects];
            for (int position = 0; position < numberTeacherSubjects; position++)
            {
                string name = Console.ReadLine();
                foreach (var item in subjects)
                {
                    if (item.Name == name)
                    {
                        teacherSubjects[position] = item;
                        break;
                    }
                }
            }
            teachers[count] = Teacher.CreateTeacher(teacherSubjects);
        }

        //Create classes
        Console.WriteLine("Enter number of classes");
        int numberClasses = int.Parse(Console.ReadLine());
        Class[] classes = new Class[numberClasses];
        for (int count = 0; count < numberClasses; count++)
        {
            Console.WriteLine("Enter number of class' teachers");
            int numberClassTeacher = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter teacher names");
            Teacher[] classTeachers = new Teacher[numberClassTeacher];
            for (int position = 0; position < numberClassTeacher; position++)
            {
                string name = Console.ReadLine();
                foreach (var item in teachers)
                {
                    if (item.Name == name)
                    {
                        classTeachers[position] = item;
                        break;
                    }
                }
            }
            classes[count] = Class.CreateClass(classTeachers);
        }

        //Create school
        School school = new School(classes, students);
    }
}