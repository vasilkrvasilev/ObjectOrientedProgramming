using System;

//class Call provides the features of the call from the eight task
public class Call
{
    private dynamic phone;
    private string dialedPhone;
    private DateTime date;
    private TimeSpan duration;

    public Call()
    {
    }

    public Call(dynamic phone, string dialedPhone)
    {
        this.phone = phone;
        this.dialedPhone = dialedPhone;
        this.date = DateTime.Now;
    }

    public dynamic Phone
    {
        get { return this.phone; }
        set { this.phone = value; }
    }

    public DateTime Date
    {
        get { return this.date; }
    }

    public TimeSpan StartTime
    {
        get { return this.date.TimeOfDay; }
    }

    public string DailedPhone
    {
        get { return this.dialedPhone; }
        set
        {
            bool incorrect = false;
            foreach (char symbol in value)
            {
                if (!Char.IsDigit(symbol))
                {
                    incorrect = true;
                }
            }
            if (incorrect)
            {
                throw new ArgumentException("Invalid input! You enter nondigit symbols.");
            }
            this.dialedPhone = value;
        }
    }

    public TimeSpan Duration
    {
        get { return this.duration; }
    }

    public TimeSpan FinishCall()
    {
        DateTime end = DateTime.Now;
        TimeSpan endTime = end.TimeOfDay;
        this.duration = end - date;
        return this.duration;
    }
}