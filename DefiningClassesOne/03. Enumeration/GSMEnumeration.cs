using System;

//class GSMEnumeration adds ToString() method to class GSM plus Main() method
public class GSMEnumeration : GSM
{
    public GSMEnumeration(string model, string manufacturer, string owner, float price) 
        : base(model, manufacturer, owner, price)
    {
    }

    public string ToString(BatteryEnumeration battery, DisplayEnumeration display)
    {
        string phoneInfo = string.Format("Phone {0} {1}\r\nowned by {2}\r\nprice ${3:F2}\r\nbattery: {4}\r\ndisplay: {5}",
            base.Manufacturer, base.Model, base.Owner, base.Price, battery.ToString(), display.ToString());
        return phoneInfo;
    }

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