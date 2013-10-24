using System;

//Create class Customer
public class Customer
{
    private bool kind;              //true equals to individual, and false to company
    private string name;

    public bool Kind
    {
        get { return this.kind; }
        set { this.kind = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Customer(bool kind, string name)
    {
        this.Kind = kind;
        this.Name = name;
    }
}


/*
second way by using enumeration
public enum Kind
{
    Individual,
    Company
}


public class Customer
{
    private Kind kind;
    private string name;

    public Kind Kind
    {
        get { return this.kind; }
        set { this.kind = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Customer(Kind kind, string name)
    {
        this.Kind = kind;
        this.Name = name;
    }
}
*/