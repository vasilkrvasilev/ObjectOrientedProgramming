using System;
using System.Linq;

//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
//Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
//Kittens and tomcats are cats. All animals are described by age, name and sex. 
//Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
//Create arrays of different kinds of animals and calculate the average age of each kind of animal 
//using a static method (you may use LINQ).

//Use classes Aminal, Dog, Frog, Cat, Kitten, Tomcat and intefase ISound
class CreateAnimal
{
    //Create generic method to select a kind of animals and calculate their average age
    static void CalculateAverageAge<T>(Animal[] differentAnimals)
    {
        var selection =
            from creature in differentAnimals
            where creature is T
            select creature;

        double averageAge = 0;
        foreach (var creature in selection)
        {
            averageAge = averageAge + creature.Age;
        }
        averageAge = averageAge / selection.Count<Animal>();
        Console.WriteLine("There are {0} animals of type {1}", selection.Count<Animal>(), typeof(T));
        Console.WriteLine("Their average age is {0}", averageAge);
        Console.WriteLine();
    }

    static void Main()
    {
        //Create different animals
        Animal[] differentAnimals =
        {
            new Animal("animal", 25, true),          //true equals to male, false to female
            new Animal("horse", 8, true),
            new Frog("frog", 1, false),
            new Frog("triton", 2, false),
            new Frog("salamander", 10, false),
            new Dog("dog", 4, true),
            new Dog("bulldog", 2, false),
            new Dog("wolf", 5, false),
            new Cat("cat", 1, true),
            new Cat("orange cat", 3, true),
            new Cat("black cat", 1, true),
            new Kitten("kitten", 2),
            new Kitten("smaller kitten", 1),
            new Tomcat("tomcat", 5),
            new Tomcat("smaller tomcat", 3)
        };

        //Calculate their average age
        CalculateAverageAge<Animal>(differentAnimals);
        CalculateAverageAge<Frog>(differentAnimals);
        CalculateAverageAge<Dog>(differentAnimals);
        CalculateAverageAge<Cat>(differentAnimals);
        CalculateAverageAge<Kitten>(differentAnimals);
        CalculateAverageAge<Tomcat>(differentAnimals);
    }
}