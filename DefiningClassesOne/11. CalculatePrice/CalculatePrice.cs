using System;
using System.Collections.Generic;

//Use classes GSMProperty, GSMHistory, History, Call, BatteryEnumeration, DisplayEnumeration and Enumeration
class CalculatePrice
{
    static void Main()
    {
        try
        {
            GSMHistory phone = History.MakeHistory();
            GSMHistory.SetMinutePrice();
            Console.WriteLine("The call history of the phone");
            List<Call> history = phone.CallHistory;
            phone.PrintHistory(history);
            Console.WriteLine("The call costs are {0}", phone.CalculateCost(history));
            phone.RemoveCall();
            Console.WriteLine("The call history of the phone");
            history = phone.CallHistory;
            phone.PrintHistory(history);
            Console.WriteLine("The call costs are {0}", phone.CalculateCost(history));
            phone.DeleteHistory();
            Console.WriteLine("The call history of the phone");
            history = phone.CallHistory;
            phone.PrintHistory(history);
            Console.WriteLine("The call costs are {0}", phone.CalculateCost(history));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}