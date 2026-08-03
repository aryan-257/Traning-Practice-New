namespace Q3_NotificationFramework;

public class WhatsAppNotification : INotification
{
    public string Channel => "WhatsApp";
    public bool IsSent { get; set; }

    public void Send(string message)
    {
        Console.WriteLine($"[WhatsApp] Sending : {message}");
        IsSent = true;
    }
}
