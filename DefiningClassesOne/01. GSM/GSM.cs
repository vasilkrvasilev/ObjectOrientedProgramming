using System;

//Tasks are solved by using inheritance
//class GSM provides the features of the phone from the first task plus Main() method
public class GSM
{
    private string model;
    private string manufacturer;
    private float price;
    private string owner;

    public GSM(string model, string manufacturer, string owner, float price)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public float Price
    {
        get { return this.price; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! The price should be a positive number.");
            }
            this.price = value; 
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    public string GetPhoneInfo()
    {
        Console.WriteLine("Enter battery model");
        string batteryModel = Console.ReadLine();
        Console.WriteLine("Enter battery endurance in idle");
        byte batteryHourIdle = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter battery endurance in talk");
        byte batteryHourTalk = byte.Parse(Console.ReadLine());
        Battery battery = new Battery(batteryModel, batteryHourIdle, batteryHourTalk);
        string batteryInfo = battery.GetBatteryInfo();

        Console.WriteLine("Enter display size");
        float displaySize = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter display colors");
        byte displayColors = byte.Parse(Console.ReadLine());
        Display display = new Display(displaySize, displayColors);
        string displayInfo = display.GetDisplayInfo();

        string phoneInfo = string.Format("Phone {0} {1}, owned by {2}, has\r\nprice ${3:F2}\r\nbattery: {4}\r\ndisplay: {5}",
            this.manufacturer, this.model, this.owner, this.price, batteryInfo, displayInfo);
        return phoneInfo;
    }

    static void Main()
    {
        Console.WriteLine("Enter phone model");
        string phoneModel = Console.ReadLine();
        Console.WriteLine("Enter phone manifacturer");
        string phoneManifacturer = Console.ReadLine();
        Console.WriteLine("Enter phone owner");
        string phoneOwner = Console.ReadLine();
        Console.WriteLine("Enter phone price");
        float phonePrice = float.Parse(Console.ReadLine());
        GSM phone = new GSM(phoneModel, phoneManifacturer, phoneOwner, phonePrice);
        string info = phone.GetPhoneInfo();
        Console.WriteLine(info);
    }
}