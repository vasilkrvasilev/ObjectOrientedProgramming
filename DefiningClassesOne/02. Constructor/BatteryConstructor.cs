using System;

//class BatteryConstructor adds the constructors from second task to class Battery
class BatteryConstructor : Battery
{
    public BatteryConstructor()
        : this(null)
    {
    }

    public BatteryConstructor(string model)
        : this(model, 2)
    {
    }

    public BatteryConstructor(string model, byte hourIdle)
        : this(model, hourIdle, 1)
    {
    }

    public BatteryConstructor(string model, byte hourIdle, byte hourTalk) : base(model, hourIdle, hourTalk)
    {
        base.Model = model;
        base.HourIdle = hourIdle;
        base.HourTalk = hourTalk;
    }
}