using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

//01. Define a class Student, which contains data about a student – first, middle and last name, SSN, 
//permanent address, mobile phone e-mail, course, specialty, university, faculty. 
//Use an enumeration for the specialties, universities and faculties. 
//Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
   
//02. Add implementations of the ICloneable interface. 
//The Clone() method should deeply copy all object's fields into a new object of type Student.

//03. Implement the  IComparable<Student> interface to compare students by names 
//(as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).

//First, second and third tasks are combine in this project
//Uses Enumeration
public class Student : ICloneable, IComparable<Student>
{
    private string firstName;
    private string middleName;
    private string lastName;
    private string socialSecurityNumber;
    private string address;
    private string phone;
    private string email;
    private string course;
    private Specialty specialty;
    private Faculty faculty;
    private University university;

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

    public string SocialSecurityNumber                   //Could contain zeros in the beginning, but can contain only digits
    {
        get { return this.socialSecurityNumber; }
        set 
        {
            int number;
            if (!int.TryParse(value, out number))
            {
                throw new ArgumentException("Invalid input! You should enter only digits.");
            }
            this.socialSecurityNumber = value; 
        }
    }

    public string Address
    {
        get { return this.address; }
        set { this.address = value; }
    }

    public string Phone                                   //Could contain zeros in the beginning, but can contain only digits
    {
        get { return this.phone; }
        set
        {
            int number;
            if (!int.TryParse(value, out number))
            {
                throw new ArgumentException("Invalid input! You should enter only digits.");
            }
            this.phone = value;
        }
    }

    public string Email                                 //Check for valid email by regular expresions
    {
        get { return this.email; }
        set 
        {
            Regex regex = new Regex(@"\w+@\w+\.\w+");
            Match match = regex.Match(value);
            if (!match.Success)
            {
                throw new ArgumentException("Invalid input! You should enter valid e-mail address.");
            }
            this.email = value; 
        }
    }

    public string Course
    {
        get { return this.course; }
        set { this.course = value; }
    }

    public Specialty Specialty                          //Uses enum Specialty
    {
        get { return this.specialty; }
        set
        {
            if ((int)value < 0 || (int)value > 4)
            {
                throw new ArgumentException("Invalid input! You should enter non-negative number less than 4.");
            }
            this.specialty = value;
        }
    }

    public Faculty Faculty                               //Uses enum Faculty
    {
        get { return this.faculty; }
        set
        {
            if ((int)value < 0 || (int)value > 4)
            {
                throw new ArgumentException("Invalid input! You should enter non-negative number less than 4.");
            }
            this.faculty = value;
        }
    }

    public University University                          //Uses enum University
    {
        get { return this.university; }
        set 
        {
            if ((int)value < 0 || (int)value > 3)
            {
                throw new ArgumentException("Invalid input! You should enter non-negative number less than 3.");
            }
            this.university = value; 
        }
    }

    public Student(string firstName, string middleName, string lastName, string socialSecurityNumber, string address,
        string phone, string email, string course, Specialty specialty, Faculty faculty, University university)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SocialSecurityNumber = socialSecurityNumber;
        this.Address = address;
        this.Phone = phone;
        this.Email = email;
        this.Course = course;
        this.Specialty = specialty;
        this.Faculty = faculty;
        this.University = university;
    }

    //Override Equals() method
    public static bool Equals(Student firstStudent, Student secondStudent)
    {
        bool isEqual = (firstStudent.socialSecurityNumber == secondStudent.socialSecurityNumber);
        return isEqual;
    }

    public static bool operator ==(Student firstStudent, Student secondStudent)
    {
        return Equals(firstStudent, secondStudent);
    }

    public static bool operator !=(Student firstStudent, Student secondStudent)
    {
        return !Equals(firstStudent, secondStudent);
    }

    public override bool Equals(object obj)
    {
        return Equals(this, obj as Student);
    }

    //Override GetHeshCode() method
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    //Override ToString() method
    public override string ToString()
    {
        string info = string.Format(
            "Student: {0} {1} {2}\r\nStudent number {3}\r\nAddress {4}\r\nPhone {5} Email {6}\r\nCourse {7}\r\n{8} {9} {10}",
            this.firstName, this.middleName, this.lastName, this.socialSecurityNumber, this.address, this.phone, this.email,
            this.course, this.specialty, this.faculty, this.university);
        return info;
    }

    //Second task - implement IClonable interface
    public object Clone()
    {
        Student clone = new Student(this.firstName, this.middleName, this.lastName, this.socialSecurityNumber, this.address,
            this.phone, this.email, this.course, this.specialty, this.faculty, this.university);
        return clone;
    }

    //Third task - implement IComparable<Student> interface
    public int CompareTo(Student other)
    {
        int compareFirstName = this.firstName.CompareTo(other.firstName);
        if (compareFirstName == 0)
        {
            int compareMiddleName = this.middleName.CompareTo(other.middleName);
            if (compareMiddleName == 0)
            {
                int compareLastName = this.lastName.CompareTo(other.lastName);
                if (compareLastName == 0)
                {
                    int compare = this.socialSecurityNumber.CompareTo(other.socialSecurityNumber);
                    return compare;
                }
                return compareLastName;
            }
            return compareMiddleName;
        }
        return compareFirstName;
    }
}