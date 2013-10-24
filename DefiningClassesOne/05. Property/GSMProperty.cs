using System;

//class GSMProperty provides the features of the phone from the fifth task without Main() method 
//plus ToString() override mathod, CreatePhone<T>() static method 
//and the field PhoneManufacturer is set as Enum (there is also a second way)
public class GSMProperty
{
    private string model;
    private PhoneManufacturer manufacturer;
    private float price;
    private string owner;
    BatteryEnumeration battery;
    DisplayEnumeration display;

    public GSMProperty()
        : this(" ", 0, " ", 0.1f, null, null)
    {
    }

    public GSMProperty(string model, PhoneManufacturer manufacturer, string owner, float price,
        BatteryEnumeration battery, DisplayEnumeration display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid input! You did not enter the phone model.");
            }
            this.model = value; 
        }
    }

    public PhoneManufacturer Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
           if ((byte)manufacturer > 5)
           {
              throw new ArgumentException("Invalid input! You should enter number between 0 and 4.");
           }
           this.manufacturer = value;
        }

        //second way - public string Manufacturer
        //set 
        //{
        //    if (value == string.Empty)
        //    {
        //        throw new ArgumentException("Invalid input! You did not enter the phone manufacturer.");
        //    }
        //    this.manufacturer = value; 
        //}
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
        set 
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid input! You did not enter the phone owner.");
            }
            if (value.Length > 70)
            {
                throw new ArgumentException("Invalid input! The owner name should be less then 70 letters.");
            }
            this.owner = value; 
        }
    }

    public BatteryEnumeration Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public DisplayEnumeration Display
    {
        get { return this.display; }
        set { this.display = value; }
    }

    public override string ToString()
    {
        string phoneInfo = string.Format("Phone {0} {1}\r\nowned by {2}\r\nprice ${3:F2}\r\nbattery: {4}\r\ndisplay: {5}",
            this.manufacturer, this.model, this.owner, this.price, this.battery.ToString(), this.display.ToString());
        return phoneInfo;
    }

    public static T CreatePhone<T>(BatteryEnumeration battery, DisplayEnumeration display)
    {
        Console.WriteLine("Enter phone model");
        string phoneModel = Console.ReadLine();
        Console.WriteLine("Enter number code of phone manufacturer");
        byte phoneManufacturer = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter phone owner");
        string phoneOwner = Console.ReadLine();
        Console.WriteLine("Enter phone price");
        float phonePrice = float.Parse(Console.ReadLine());
        object[] args = new object[] { phoneModel, (PhoneManufacturer)phoneManufacturer, phoneOwner, phonePrice, battery, display };
        return (T)Activator.CreateInstance(typeof(T), args);
    }
}