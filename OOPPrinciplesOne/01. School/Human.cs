using System;

//Create class Human, which inherits interface IComment
public class Human : IComment
{
    private string name;
    private string comment;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Comment
    {
        get { return this.comment; }
        set { this.comment = value; }
    }

    public Human(string name)
    {
        this.Name = name;
    }

    public void Print()
    {
        Console.WriteLine(this.comment);
    }
}