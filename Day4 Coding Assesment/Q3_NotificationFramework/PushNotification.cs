namespace Q3_NotificationFramework;

public class PushNotification : INotification
{
    public string Channel => "Push";
    public bool IsSent { get; set; }

    public void Send(string message)
    {
        Console.WriteLine($"[Push] Sending : {message}");
        IsSent = true;
    }
}
