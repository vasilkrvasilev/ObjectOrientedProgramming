using System;

//Use classes GSMProperty, GSMStatic, BatteryEnumeration, DisplayEnumeration and Enumeration
public class Static
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
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}