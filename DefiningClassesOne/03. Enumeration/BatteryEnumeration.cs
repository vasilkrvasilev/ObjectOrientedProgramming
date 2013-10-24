using System;

//class BatteryEnumeration provides the features of the battery from the third task
public class BatteryEnumeration
{
    private string model;
    private float hourIdle;
    private float hourTalk;
    private BatteryType type;

    public BatteryEnumeration() : this(" ", 0.02f, 0.01f, 0)
    {
    }

    public BatteryEnumeration(string model, float hourIdle, float hourTalk, BatteryType type)
    {
        this.model = model;
        this.hourIdle = hourIdle;
        this.hourTalk = hourTalk;
        this.type = type;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("Invalid input! You did not enter the battery model.");
            }
            this.model = value;
        }
    }

    public float HourIdle
    {
        get { return this.hourIdle; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! The endurance in idle should be a positive number.");
            }
            this.hourIdle = value;
        }
    }

    public float HourTalk
    {
        get { return this.hourTalk; }
        set
        {
            if (value <= 0 || value >= hourIdle)
            {
                throw new ArgumentException(
                    "Invalid input! The endurance in talk should be a positive number and less than endurance in idle.");
            }
            this.hourTalk = value;
        }
    }

    public BatteryType Type
    {
        get { return this.type; }
        set
        {
            if ((byte)type > 4)
            {
                throw new ArgumentException("Invalid input! You should enter number between 0 and 4.");
            }
            this.type = value;
        }
    }

    public static BatteryEnumeration CreateBattery()
    {
        Console.WriteLine("Enter battery model");
        string batteryModel = Console.ReadLine();
        Console.WriteLine("Enter battery endurance in idle");
        float batteryHourIdle = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter battery endurance in talk");
        float batteryHourTalk = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter number code of battery type");
        byte batteryType = byte.Parse(Console.ReadLine());
        BatteryEnumeration battery = new BatteryEnumeration(batteryModel, batteryHourIdle, batteryHourTalk, (BatteryType)batteryType);
        return battery;
    }

    public override string ToString()
    {
        string batteryInfo = string.Format(
            "\r\n\ttype {0}\r\n\tmodel {1}\r\n\t{2} hours endurance in idle\r\n\t{3} hours endurance in talk",
            this.type, this.model, this.hourIdle, this.hourTalk);
        return batteryInfo;
    }
}