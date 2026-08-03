namespace Q3_NotificationFramework;

public class NotificationManager
{
    public void Send(string message , params INotification[] channels)
    {
        foreach(var channel in channels)
        {
            channel.Send(message);
            Console.WriteLine($"  -> {channel.Channel} status : {(channel.IsSent ? "Sent" : "Failed")}");
        }
    }
}
