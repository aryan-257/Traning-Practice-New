namespace Q3_NotificationFramework;

public interface INotification
{
    string Channel { get; }
    bool IsSent { get; set; }
    void Send(string message);
}
