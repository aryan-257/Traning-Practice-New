namespace Q13_EventManagement;

public interface IRegistrable
{
    void Register(string userName);
}

public interface INotifiable
{
    void Notify(string message);
}
