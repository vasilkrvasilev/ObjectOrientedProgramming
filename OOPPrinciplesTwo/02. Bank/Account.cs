using System;

//Create abstract class Account with abstract property balance
public abstract class Account
{
    private Customer customer;
    private float interestRate;
    private double balance;

    public Customer Customer
    {
        get { return this.customer; }
        set { this.customer = value; }
    }

    public float InterestRate
    {
        get { return this.interestRate; }
        set 
        {
            if (value <= 0 || value >= 100)
            {
                throw new ArgumentException("Invalid input! You should enter positive number less then 100 for interest rate.");
            }
            this.interestRate = value; 
        }
    }

    public abstract double Balance { get; set; }

    public Account(Customer customer, float interestRate)
    {
        this.Customer = customer;
        this.InterestRate = interestRate;
    }

    public void DepositMoney(double amount)
    {
        if (amount > 0)
        {
            this.balance += amount;
            Console.WriteLine("Deposit is completed. Your balance is {0}.", this.balance);
        }
        else
        {
            Console.WriteLine("You cannot deposit non-positive amount of money");
        }
    }
}