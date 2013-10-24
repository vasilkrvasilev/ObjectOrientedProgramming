using System;
using System.Linq;

//Create class Cat, which inherits class Animal
public class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age)
    {
    }
    public Cat(string name, int age, bool sex) : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Miau-Miau");
    }
}