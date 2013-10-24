using System;

//Use classes GSMProperty, BatteryEnumeration, DisplayEnumeration and Enumeration
public class Property
{
    static void Main()
    {
        try
        {
            BatteryEnumeration battery = BatteryEnumeration.CreateBattery();
            DisplayEnumeration display = DisplayEnumeration.CreateDisplay();
            GSMProperty phone = GSMProperty.CreatePhone<GSMProperty>(battery, display);
            string info = phone.ToString();
            Console.WriteLine(info);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}