namespace Q13_EventManagement;

public abstract class BaseEvent : IRegistrable , INotifiable
{
    public int    eventId;
    public string eventName;
    public DateTime eventDate;
    public List<string> registeredUsers = new List<string>();

    public BaseEvent(int id , string name , DateTime date)
    {
        eventId = id; eventName = name; eventDate = date;
    }

    public void Register(string userName)
    {
        registeredUsers.Add(userName);
        Console.WriteLine($"{userName} registered for {eventName}");
    }

    public void Notify(string message)
    {
        foreach(var user in registeredUsers)
            Console.WriteLine($"  Reminder to {user} : {message}");
    }

    public abstract string GetEventType();
}
