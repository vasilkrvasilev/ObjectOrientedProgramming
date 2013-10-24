using System;

//Create interface IAccount
public interface IAccount
{
    void DepositMoney(double amount);
    double CalculateInterest(byte startMonth, byte endMonth);
}