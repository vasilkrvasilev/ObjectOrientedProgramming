using System;
using System.Collections.Generic;

//Use classes GSMProperty, GSMHistory, History, Call, BatteryEnumeration, DisplayEnumeration and Enumeration
class AddRemove
{
    static void Main()
    {
        try
        {
            GSMHistory phone = History.MakeHistory();

            Console.WriteLine("The call history of the phone");
            List<Call> history = phone.CallHistory;
            phone.PrintHistory(history);
            phone.RemoveCall();
            Console.WriteLine("The call history of the phone");
            history = phone.CallHistory;
            phone.PrintHistory(history);
            phone.DeleteHistory();
            Console.WriteLine("The call history of the phone");
            history = phone.CallHistory;
            phone.PrintHistory(history);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}