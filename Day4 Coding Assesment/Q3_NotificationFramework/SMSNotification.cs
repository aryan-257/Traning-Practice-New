namespace Q3_NotificationFramework;

public class SMSNotification : INotification
{
    public string Channel => "SMS";
    public bool IsSent { get; set; }

    public void Send(string message)
    {
        Console.WriteLine($"[SMS] Sending : {message}");
        IsSent = true;
    }
}
