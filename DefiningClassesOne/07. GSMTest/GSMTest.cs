using System;
using System.Text;

//Use classes GSMProperty, GSMStatic, BatteryEnumeration, DisplayEnumeration and Enumeration
class GSMTest
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter number of phones");
            int number = int.Parse(Console.ReadLine());
            string[] array = new string[number];
            for (int count = 0; count < number; count++)
            {
                BatteryEnumeration battery = BatteryEnumeration.CreateBattery();
                DisplayEnumeration display = DisplayEnumeration.CreateDisplay();
                GSMStatic phone = GSMProperty.CreatePhone<GSMStatic>(battery, display);
                string info = phone.ToString();
                array[count] = info;
                Console.WriteLine();
            }

            foreach (var phoneInfo in array)
            {
                Console.WriteLine("Phone info:");
                Console.WriteLine(phoneInfo);
                Console.WriteLine();
                Console.WriteLine("Phone info about iPhone 4S:");
                Console.WriteLine(GSMStatic.IPhone4S);
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}