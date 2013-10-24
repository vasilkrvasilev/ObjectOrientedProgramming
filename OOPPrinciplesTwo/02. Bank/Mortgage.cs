using System;

//Inherits class Credit and IAccount interface and implement method CalculateInterest()
public class Mortgage : Credit, IAccount
{
    public Mortgage(Customer customer, float interestRate, double balance)
        : base(customer, interestRate, balance)
    {
    }

    public double CalculateInterest(byte startMonth, byte endMonth)
    {
        double interest = 0;
        byte period = 0;
        byte halfPeriod = 0;
        if (Customer.Kind && startMonth <= 6)
        {
            if (endMonth > 6)
            {
                period = (byte)(endMonth - 6);
            }
        }

        if (!Customer.Kind && endMonth > startMonth)
        {
            if (startMonth <= 12 && endMonth <= 12)
            {
                halfPeriod = (byte)(endMonth - startMonth);
            }

            if (startMonth <= 12 && endMonth > 12)
            {
                halfPeriod = (byte)(12 - startMonth);
                period = (byte)(endMonth - 12);
            }

            if (startMonth > 12 && endMonth > 12)
            {
                period = (byte)(endMonth - startMonth);
            }
        }

        interest = (period * base.InterestRate * base.Balance) + (halfPeriod * base.InterestRate * (0.5) * (-base.Balance));
        return interest;
    }
}