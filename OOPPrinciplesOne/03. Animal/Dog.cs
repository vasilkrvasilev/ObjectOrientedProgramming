using System;
using System.Linq;

//Create class Dog, which inherits class Animal
public class Dog : Animal
{
    public Dog(string name, int age, bool sex) : base(name, age, sex)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bau-Bou");
    }
}