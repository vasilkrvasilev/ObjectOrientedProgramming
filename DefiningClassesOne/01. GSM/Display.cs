using System;

//Tasks are solved by using inheritance
//class Display provides the features of the display from the first task
public class Display
{
    private float inches;
    private byte numberColors;

    public Display(float inches, byte numberColors)
    {
        this.inches = inches;
        this.numberColors = numberColors;
    }

    public float Inches
    {
        get { return this.inches; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! The size should be a positive number.");
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
                throw new ArgumentException("Invalid input! The number of colors should be a positive number.");
            }
            this.numberColors = value; 
        }
    }

    public string GetDisplayInfo()
    {
        string displayInfo = string.Format("size {0} inches, maintains {1} different colors", this.inches, this.numberColors);
        return displayInfo;
    }
}
