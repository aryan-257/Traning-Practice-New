using Q13_EventManagement;

var mgr = new EventManager<BaseEvent>();
mgr.Add(new Conference(101 , "TechConf 2026"   , new DateTime(2026,8,10)));
mgr.Add(new Workshop  (102 , "CSharp Workshop" , new DateTime(2026,8,12)));
mgr.Add(new Webinar   (103 , "AI Webinar"      , new DateTime(2026,8,15)));

mgr[101].Register("Aryan");
mgr[101].Register("Sneha");
mgr[102].Register("Rahul");
mgr[103].Register("Priya");

Console.WriteLine("\nEvent Summaries :");
foreach(var ev in mgr.GetAll())
{
    var summary = new
    {
        ev.eventId,
        ev.eventName,
        Type        = ev.GetEventType(),
        Registrants = ev.registeredUsers.Count,
        Date        = ev.eventDate.ToShortDateString()
    };
    Console.WriteLine($"  [{summary.eventId}] {summary.eventName} | {summary.Type} | {summary.Date} | Registrants:{summary.Registrants}");
}

Console.WriteLine("\nSending reminders for TechConf 2026 :");
mgr[101].Notify("Event starts in 2 days!");
