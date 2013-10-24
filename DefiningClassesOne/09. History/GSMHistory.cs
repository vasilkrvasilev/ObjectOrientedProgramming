using System;
using System.Collections.Generic;

//class GSMHistory adds fields, properties and methods to class GSMStatic according to tasks nine, ten eleven and twelve
public class GSMHistory : GSMStatic
{
    private List<Call> callHistory;
    private static double minutePrice;

    public GSMHistory()
        : base()
    {
    }

    public GSMHistory(string model, PhoneManufacturer manufacturer, string owner, float price,
        BatteryEnumeration battery, DisplayEnumeration display)
        : base(model, manufacturer, owner, price, battery, display)
    {
        this.callHistory = new List<Call>();
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }

    public static double MinutePrice
    {
        get { return minutePrice; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input! You should enter a non-negative number.");
            }
            minutePrice = value;
        }
    }

    public static void SetMinutePrice()
    {
        Console.WriteLine("Enter price per minute");
        minutePrice = double.Parse(Console.ReadLine());
    }

    public void PrintHistory(List<Call> history)
    {
        foreach (Call call in history)
        {
            Console.WriteLine("You called {0}", call.DailedPhone);
            Console.WriteLine("Date {0:dd:MM:yyyy}", call.Date);
            Console.WriteLine("at {0} o'clock", call.StartTime);
            Console.WriteLine("The call duration was {0}", call.Duration);
        }
    }

    public void AddCall(Call currentCall)
    {
        this.callHistory.Add(currentCall);
    }

    public List<Call> RemoveCall()
    {
        Console.WriteLine("Enter the number of call you want to remove starting from 0");
        int removedCall = int.Parse(Console.ReadLine());
        if (removedCall < 0 || removedCall >= this.callHistory.Count)
        {
            Console.WriteLine("There is no sush call");
        }
        else
        {
            this.callHistory.RemoveAt(removedCall);
        }
        return this.callHistory;
    }

    public List<Call> RemoveLongestCall()
    {
        int index = 0;
        int maxLength = 0;
        for (int position = 0; position < this.callHistory.Count; position++)
        {
            if (this.callHistory[position].Duration.Seconds > maxLength)
            {
                maxLength = this.callHistory[position].Duration.Seconds;
                index = position;
            }
        }
        this.callHistory.RemoveAt(index);
        return this.callHistory;
    }

    public List<Call> DeleteHistory()
    {
        Console.WriteLine("Do you want to delete call history");
        string delete = Console.ReadLine();
        if (delete.ToLower() == "yes")
        {
            this.callHistory.Clear();
        }
        return this.callHistory;
    }

    public double CalculateCost(List<Call> history)
    {
        int callTime = 0;
        foreach (var call in history)
        {
            callTime += call.Duration.Seconds;
        }
        int payTime = 0;
        if (callTime % 60 == 0)
        {
            payTime = callTime / 60;
        }
        else
        {
            payTime = (callTime / 60) + 1;
        }
        double cost = payTime * minutePrice;
        return cost;
    }
}