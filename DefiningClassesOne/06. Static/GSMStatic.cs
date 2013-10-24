using System;

//class GSMStatic adds static field and property IPhone4S to class GSMProperty plus (there is also a second way)
public class GSMStatic : GSMProperty
{
    //private static string iPhone = " ";
    private static GSMStatic iPhone4S;

    public GSMStatic()
        : base()
    {
    }

    public GSMStatic(string model, PhoneManufacturer manufacturer, string owner, float price,
        BatteryEnumeration battery, DisplayEnumeration display)
        : base(model, manufacturer, owner, price, battery, display)
    {
    }

    /* second way
    public static string IPhone
    {
        get
        {
            if (iPhone.ToLower() == "yes")
            {
                return "Phone Apple iPhone 4S\r\nowner Ivan Ivaov\r\nprice $350\r\nbattery:" +
                    "\r\n\ttype LiPo\r\n\tmodel 1432 mAh\r\n\t200 hours endurance in idle\r\n\t14 hours endurance in talk" +
                    "\r\ndisplay:\r\n\t3.5 inches\r\n\t16 different colors";
            }
            else
            {
                return iPhone;
            }
        }
        set { iPhone = value; }
    }
     
    public static void GetIPhoneInfo()
    {
        Console.WriteLine("Do you want phone info about iPhone 4S");
        GSMStatic.IPhone = Console.ReadLine();
    }
     */

    public static GSMStatic IPhone4S
    {
        get
        {
            BatteryEnumeration iPhone4SBattery = new BatteryEnumeration("1432 mAh", 200f, 14f, (BatteryType)1);
            DisplayEnumeration iPhone4SDisplay = new DisplayEnumeration(3.5f, 16);
            iPhone4S = new GSMStatic("iPhone 4S", (PhoneManufacturer)4, "** ***", 350f, iPhone4SBattery, iPhone4SDisplay);
            return iPhone4S;
        }
    }
}