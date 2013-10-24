using System;
using System.Collections.Generic;
using System.Linq;

//Create abstract class Human
public abstract class Human
{
    private string comment;

    public abstract string FirstName { get; set; }
    public abstract string LastName { get; set; }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public void Print()
    {
        Console.WriteLine(this.comment);
    }
}