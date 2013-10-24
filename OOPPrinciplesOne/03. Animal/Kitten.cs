using System;
using System.Linq;

//Create class Kitten, which inherits class Cat
public class Kitten : Cat
{
    public Kitten(string name, int age) : base(name, age)
    {
        this.Sex = false;               //false equals to female
    }
}