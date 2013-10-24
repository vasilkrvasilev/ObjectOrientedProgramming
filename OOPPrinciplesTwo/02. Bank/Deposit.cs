using System;

//Inherits abstract class Account and IAccount interface and 
//implement property balance as a positive value and method CalculateInterest()
public class Deposit : Account, IAccount
{
    private double balance;

    public override double Balance
    {
        get { return this.balance; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input! You should enter non-negative number for balance.");
            }
            this.balance = value;
        }
    }

    public Deposit(Customer customer, float interestRate, double balance) : base(customer, interestRate)
    {
        this.Balance = balance;
    }

    public double CalculateInterest(byte startMonth, byte endMonth)
    {
        double interest = 0;
        byte period = (byte)(endMonth - startMonth);
        if (this.balance < 1000)
        {
            return interest;
        }
        else
        {
            interest = period * base.InterestRate * this.balance;
            return interest;
        }
    }

    public void WithDrawMoney(double amount)
    {
        if (amount > 0)
        {
            this.balance -= amount;
            Console.WriteLine("With draw is completed. Your balance is {0}.", this.balance);
        }
        else
        {
            Console.WriteLine("You cannot with draw non-positive amount of money");
        }
    }
}