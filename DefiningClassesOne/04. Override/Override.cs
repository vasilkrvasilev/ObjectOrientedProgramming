using System;

//Use classes from 03. Enumeration - ToString is overrire for BatteryEnumeration and DisplayEnumeration
class Override
{
    static void Main()
    {
        Console.WriteLine("Enter phone model");
        string phoneModel = Console.ReadLine();
        Console.WriteLine("Enter phone manifacturer");
        string phoneManufacturer = Console.ReadLine();
        Console.WriteLine("Enter phone owner");
        string phoneOwner = Console.ReadLine();
        Console.WriteLine("Enter phone price");
        float phonePrice = float.Parse(Console.ReadLine());
        BatteryEnumeration battery = BatteryEnumeration.CreateBattery();
        DisplayEnumeration display = DisplayEnumeration.CreateDisplay();
        GSMEnumeration phone = new GSMEnumeration(phoneModel, phoneManufacturer, phoneOwner, phonePrice);
        string info = phone.ToString(battery, display);
        Console.WriteLine(info);
    }
}