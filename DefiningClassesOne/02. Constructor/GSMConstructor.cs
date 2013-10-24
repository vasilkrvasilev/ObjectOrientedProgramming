using System;

//class GSMConstructor provides the features of the phone from the second task plus Main() method
class GSMConstructor
{
    private string model;
    private string manufacturer;
    private float price;
    private string owner;
    private BatteryConstructor battery = new BatteryConstructor();
    private DisplayConstructor display = new DisplayConstructor();

    public GSMConstructor(string model, string manufacturer) 
        : this(model, manufacturer, null)
    {
    }

    public GSMConstructor(string model, string manufacturer, string owner) 
        : this(model, manufacturer, owner, 0)
    {
    }

    public GSMConstructor(string model, string manufacturer, string owner, float price)
        : this(model, manufacturer, owner, price, new BatteryConstructor())
    {
    }

    public GSMConstructor(string model, string manufacturer, string owner, float price, BatteryConstructor battery)
        : this(model, manufacturer, owner, price, battery, new DisplayConstructor())
    {
    }

    public GSMConstructor(string model, string manufacturer, string owner, float price, 
        BatteryConstructor battery, DisplayConstructor display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string Manifacturer
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
        string phoneInfo = string.Format("Phone {0} {1}, owned by {2}, has\r\nprice ${3:F2}\r\nbattery: {4}\r\ndisplay: {5}",
            this.manufacturer, this.model, this.owner, this.price, battery.GetBatteryInfo(), display.GetDisplayInfo());
        return phoneInfo;
    }

    static void Main()
    {
        Console.WriteLine("Enter phone model");
        string phoneModel = Console.ReadLine();
        Console.WriteLine("Enter phone manifacturer");
        string phoneManifacturer = Console.ReadLine();
        GSMConstructor phone = new GSMConstructor(phoneModel, phoneManifacturer);
        string info = phone.GetPhoneInfo();
        Console.WriteLine(info);
    }
}