using System;

//Tasks are solved by using inheritance
//class Battery provides the features of the battery from the first task
public class Battery
{
    private string model;
    private byte hourIdle;
    private byte hourTalk;

    public Battery(string model, byte hourIdle, byte hourTalk)
    {
        this.model = model;
        this.hourIdle = hourIdle;
        this.hourTalk = hourTalk;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public byte HourIdle
    {
        get { return this.hourIdle; }
        set 
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid input! The endurance should be a positive number.");
            }
            this.hourIdle = value; 
        }
    }

    public byte HourTalk
    {
        get { return this.hourTalk; }
        set 
        {
            if (value <= 0 || value >= this.hourIdle)
            {
                throw new ArgumentException(
                    "Invalid input! The endurance in talk should be a positive number and less than endurance in idle.");
            }
            this.hourTalk = value; 
        }
    }

    public string GetBatteryInfo()
    {
        string batteryInfo = string.Format("model {0}, endurance in idle - {1} hours, in talk - {2} hours",
            this.model, this.hourIdle, this.hourTalk);
        return batteryInfo;
    }
}