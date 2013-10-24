using System;
using System.Linq;

//Create class Tomcat, which inherits class Cat
public class Tomcat : Cat
{
    public Tomcat(string name, int age) : base(name, age)
    {
        this.Sex = true;                //true equals to male
    }
}