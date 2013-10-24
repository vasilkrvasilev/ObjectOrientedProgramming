using System;
using System.Linq;

//Create class Animal, which inherits interface ISound
public class Animal : ISound
{
    private string name;
    private int age;
    private bool sex;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! You should enter positive number for age.");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public bool Sex           //true equals to male, false to female
    {
        get { return this.sex; }
        set { this.sex = value; }
    }

    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Animal(string name, int age, bool sex) : this(name, age)
    {
        this.Sex = sex;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("I am an animal");
    }

    public double GetAverage(Animal[] animals)
    {
        double sumAge = 0;
        foreach (var item in animals)
        {
            sumAge += item.Age;
        }
        return sumAge / animals.Length;
    }

    public static Animal CreateAnimal()
    {
        Console.WriteLine("Enter animal name");
        string animalName = Console.ReadLine();
        Console.WriteLine("Enter animal age");
        int animalAge = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter animal sex");
        string input = Console.ReadLine();
        bool animalSex = true;
        if (input.ToLower() == "female")
        {
            animalSex = false;
        }

        Animal animal = new Animal(animalName, animalAge, animalSex);
        return animal;
    }
}