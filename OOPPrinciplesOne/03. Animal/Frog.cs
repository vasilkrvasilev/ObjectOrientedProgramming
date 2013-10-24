using System;
using System.Linq;

//Create class Frog, which inherits class Animal
public class Frog : Animal
{
    public Frog(string name, int age, bool sex) : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Kwak-Kwak");
    }
}