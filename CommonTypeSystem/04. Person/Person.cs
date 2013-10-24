using System;

//Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. 
//Override ToString() to display the information of a person and if age is not specified – to say so. 
//Write a program to test this functionality.

//Create class Person
public class Person
{
    private string name;
    private byte? age = null;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    //Age could be null or non-negative small number - its initial value is null (value of field age)
    public byte? Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Person(string name, byte? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    //Override ToString() method
    public override string ToString()
    {
        string info = string.Format("Person name: {0} \r\nPerson age {1}", this.name, this.age);
        if (this.age == null)
        {
            info += "\r\nThe Person age is not specified, because it is unknown.";
        }
        return info;
    }
}