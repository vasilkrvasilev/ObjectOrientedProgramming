using System;
using System.Collections.Generic;

//Use classes GSMProperty, GSMHistory, Call, BatteryEnumeration, DisplayEnumeration and Enumeration
// and declare a MakeHistory() method
public class History
{
    public static GSMHistory MakeHistory()
    {
        BatteryEnumeration battery = BatteryEnumeration.CreateBattery();
        DisplayEnumeration display = DisplayEnumeration.CreateDisplay();
        GSMHistory phone = GSMProperty.CreatePhone<GSMHistory>(battery, display);
        string info = phone.ToString();
        Console.WriteLine("Phone info:");
        Console.WriteLine(info);
        Console.WriteLine();
        Console.WriteLine("Phone info about iPhone 4S:");
        Console.WriteLine(GSMHistory.IPhone4S);
        Console.WriteLine();
        byte dialing = 0;
        do
        {
            Console.WriteLine("For new dial enter 1, for last dial enter 0");
            dialing = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter dailed phone number");
            string dialedNumber = Console.ReadLine();
            Call call = new Call(phone, dialedNumber);
            Console.WriteLine("Press enter to finish the call");
            Console.ReadLine();
            call.FinishCall();
            phone.AddCall(call);
        }
        while (dialing == 1);

        return phone;
    }

    static void Main()
    {
        try
        {
            GSMHistory phone = MakeHistory();
            Console.WriteLine("The call history of the phone");
            List<Call> history = phone.CallHistory;
            phone.PrintHistory(history);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}