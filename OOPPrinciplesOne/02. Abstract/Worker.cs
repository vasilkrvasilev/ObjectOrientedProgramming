using System;

//Class Worker inherits abstract class Human
public class Worker : Human
{
    private double weekSalary;
    private int workHoursPerDay;
    private string firstName;
    private string lastName;

    public double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value > 0)
            {
                this.weekSalary = value;
            }
            else
            {
                throw new ArgumentException("Invalid input! You should enter positive number for week salary.");
            }
        }
    }

    public int WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set 
        {
            if (value > 0)
            {
                this.workHoursPerDay = value; 
            }
            else
            {
                throw new ArgumentException("Invalid input! You should enter positive number for work hours per day.");
            }
        }
    }

    public override string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public override string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public Worker(double weekSalary, int workHoursPerDay, string firstName, string lastName)
        : base()
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public static Worker CreateWorker()
    {
        Console.WriteLine("Enter worker week salary");
        double workerWeekSalary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter worker work hours per day");
        int workerWorkHoursPerDay = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter worker first name");
        string workerFirstName = Console.ReadLine();
        Console.WriteLine("Enter worker last name");
        string workerLastName = Console.ReadLine();
        Worker worker = new Worker(workerWeekSalary, workerWorkHoursPerDay, workerFirstName, workerLastName);
        Console.WriteLine("Enter comment");
        worker.Comment = Console.ReadLine();
        return worker;
    }

    public double MoneyPerHour()
    {
        int weekWorkHours = this.workHoursPerDay * 5;
        double salaryPerHour = weekWorkHours / this.weekSalary;
        return salaryPerHour;
    }
}