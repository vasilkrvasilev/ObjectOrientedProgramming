using System;
using System.Threading;
using System.Threading.Tasks;

public delegate void Method(params string[] input);
public delegate void Method<T>(T input);

//Create event
public class Event : EventArgs
{
    public Event(string text)
    {
        message = text;
    }
    private string message;

    public string Message
    {
        get { return message; }
        set { message = value; }
    }
}

//Determines when an event is raised
public class Publisher
{
    public event EventHandler<Event> RaiseEvent;

    public void Execute(int interval)
    {
        Thread.Sleep(interval * 1000);
        OnRaiseEvent(new Event("Executed program"));
    }
    protected virtual void OnRaiseEvent(Event e)
    {
        EventHandler<Event> handler = RaiseEvent;

        if (handler != null)
        {
            e.Message += String.Format(" at {0}", DateTime.Now.ToString());
            handler(this, e);
        }
    }
}

//Determines what to execute when an event is raised
public class Subscriber
{
    private string id;
    public Subscriber(string ID, Publisher publisher)
    {
        id = ID;
        publisher.RaiseEvent += HandleEvent;
    }
 
    void HandleEvent(object sender, Event e)
    {
        Console.WriteLine(id + " received this message: {0}", e.Message);
    }
}

//Execute events
public class EventX
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();
        Subscriber subscriber = new Subscriber("Subscriber", publisher);
        Console.WriteLine("Enter time interval in seconds");
        int interval = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of iterations");
        int iterations = int.Parse(Console.ReadLine());
        for (int count = 0; count < iterations; count++)
        {
            publisher.Execute(interval);
        }
        Console.WriteLine("Press Enter");
        Console.ReadLine();
    }
}