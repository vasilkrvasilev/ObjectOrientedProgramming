using System;

//Inherits abstract class Account and implement property balance as a negative value
public class Credit : Account
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
            this.balance = -value;
        }
    }

    public Credit(Customer customer, float interestRate, double balance) : base(customer, interestRate)
    {
        this.Balance = balance;
    }
}