namespace Q3_NotificationFramework;

public class EmailNotification : INotification
{
    public string Channel => "Email";
    public bool IsSent { get; set; }

    public void Send(string message)
    {
        Console.WriteLine($"[Email] Sending : {message}");
        IsSent = true;
    }
}
