namespace Q13_EventManagement;

public class Conference : BaseEvent
{
    public Conference(int id , string name , DateTime date) : base(id,name,date) {}
    public override string GetEventType() => "Conference";
}

public class Workshop : BaseEvent
{
    public Workshop(int id , string name , DateTime date) : base(id,name,date) {}
    public override string GetEventType() => "Workshop";
}

public class Webinar : BaseEvent
{
    public Webinar(int id , string name , DateTime date) : base(id,name,date) {}
    public override string GetEventType() => "Webinar";
}
