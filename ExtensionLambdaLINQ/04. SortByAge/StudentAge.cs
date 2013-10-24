using System;
using System.Linq;

//Inherited class Student
public class StudentAge : Student
{
    private byte age;

    public byte Age
    {
        get { return this.age; }
        set
        {
            if (value > 0 && value < 100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("Invalid input! You shoul enter a positive number less then 100.");
            }
        }
    }

    public StudentAge(string firstName, string lastName, byte age) : base(firstName, lastName)
    {
        this.Age = age;
    }
}