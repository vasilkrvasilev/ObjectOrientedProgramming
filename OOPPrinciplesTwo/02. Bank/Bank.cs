using System;

//A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//Customers could be individuals or companies. All accounts have customer, balance and interest rate (monthly based). 
//Deposit accounts are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: 
//number_of_months * interest_rate. Loan accounts have no interest for the first 3 months if are held by individuals 
//and for the first 2 months if are held by a company. Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Your task is to write a program to model the bank system by classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions 
//and implement the calculation of the interest functionality through overridden methods.

//Use classes Customer, Account, Deposit, Credit, Loan, Mortgage
public class Bank
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int number = int.Parse(Console.ReadLine());
        try
        {
            for (int count = 0; count < number; count++)
            {
                Console.WriteLine("Enter customer kind");               //true equals to individual, and false to company
                bool customerKind = bool.Parse(Console.ReadLine());
                Console.WriteLine("Enter customer name");
                string customerName = Console.ReadLine();
                Customer customer = new Customer(customerKind, customerName);
                Console.WriteLine("Enter interest rate");
                float currentInterestRate = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter account balance");
                double currentBalance = double.Parse(Console.ReadLine());
                Deposit deposit = new Deposit(customer, currentInterestRate, currentBalance);
                Loan loan = new Loan(customer, currentInterestRate, currentBalance);
                Mortgage mortgage = new Mortgage(customer, currentInterestRate, currentBalance);
                Console.WriteLine("Enter start month");
                byte startMonth = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter end month");
                byte endMonth = byte.Parse(Console.ReadLine());
                Console.WriteLine("Interest for the deposit is {0}", deposit.CalculateInterest(startMonth, endMonth));
                Console.WriteLine("Interest for the loan is {0}", loan.CalculateInterest(startMonth, endMonth));
                Console.WriteLine("Interest for the morgage is {0}", mortgage.CalculateInterest(startMonth, endMonth));
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}
