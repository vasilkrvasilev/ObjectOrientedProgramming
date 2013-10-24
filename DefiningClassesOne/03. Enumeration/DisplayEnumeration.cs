using System;

//class DisplayEnumeration provides the features of the display from the third task
public class DisplayEnumeration
{
    private float inches;
    private byte numberColors;

    public DisplayEnumeration() : this(0.1f, 2)
    {
    }

    public DisplayEnumeration(float inches, byte numberColors)
    {
        this.inches = inches;
        this.numberColors = numberColors;
    }

    public float Inches
    {
        get { return this.inches; }
        set
        {
            if (value <= 0 || value > 10)
            {
                throw new ArgumentException("Invalid input! The size should be a positive number less then 10.");
            }
            this.inches = value;
        }
    }

    public byte NumberColors
    {
        get { return this.numberColors; }
        set
        {
            if (value <= 1)
            {
                throw new ArgumentException("Invalid input! The number of colors should be a positive number bigger then 1.");
            }
            this.numberColors = value;
        }
    }

    public static DisplayEnumeration CreateDisplay()
    {
        Console.WriteLine("Enter display size");
        float displaySize = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter display colors");
        byte displayColors = byte.Parse(Console.ReadLine());
        DisplayEnumeration display = new DisplayEnumeration(displaySize, displayColors);
        return display;
    }

    public override string ToString()
    {
        string displayInfo = string.Format("\r\n\t{0} inches\r\n\t{1} different colors", this.inches, this.numberColors);
        return displayInfo;
    }
}