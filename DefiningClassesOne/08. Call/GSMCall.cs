using System;

//Use classes GSMProperty, GSMStatic, Call, BatteryEnumeration, DisplayEnumeration and Enumeration
public class GSMCall
{
    static void Main()
    {
        try
        {
            BatteryEnumeration battery = BatteryEnumeration.CreateBattery();
            DisplayEnumeration display = DisplayEnumeration.CreateDisplay();
            GSMStatic phone = GSMProperty.CreatePhone<GSMStatic>(battery, display);
            string info = phone.ToString();
            Console.WriteLine("Phone info:");
            Console.WriteLine(info);
            Console.WriteLine();
            Console.WriteLine("Phone info about iPhone 4S:");
            Console.WriteLine(GSMStatic.IPhone4S);
            Console.WriteLine();
            Console.WriteLine("Enter dailed phone number");
            string dialedNumber = Console.ReadLine();
            Call call = new Call(phone, dialedNumber);
            Console.WriteLine("You called {0}", call.DailedPhone);
            Console.WriteLine("Date {0:dd:MM:yyyy}", call.Date);
            Console.WriteLine("at {0} o'clock", call.StartTime);
            Console.WriteLine("Press enter to finish the call");
            Console.ReadLine();
            Console.WriteLine("The call duration was {0}", call.FinishCall());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}