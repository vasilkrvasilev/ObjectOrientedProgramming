using System;

//Inherits class Credit and IAccount interface and implement method CalculateInterest()
public class Loan : Credit, IAccount
{
    public Loan(Customer customer, float interestRate, double balance)
        : base(customer, interestRate, balance)
    {
    }

    public double CalculateInterest(byte startMonth, byte endMonth)
    {
        double interest = 0;
        byte period = 0;
        if (Customer.Kind && startMonth <= 3)
        {
            if (endMonth > 3)
            {
                period = (byte)(endMonth - 3);
            }
        }

        if (!Customer.Kind && startMonth <= 2)
        {
            if (endMonth > 2)
            {
                period = (byte)(endMonth - 2);
            }
        }
        interest = period * base.InterestRate * (-base.Balance);
        return interest;
    }
}