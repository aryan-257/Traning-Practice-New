namespace Q13_EventManagement;

public class EventManager<T> where T : BaseEvent
{
    private Dictionary<int , T> _events = new Dictionary<int , T>();

    public void Add(T ev) { _events[ev.eventId] = ev; }

    public T this[int id]
    {
        get
        {
            if(!_events.ContainsKey(id)) throw new Exception("Event not found : " + id);
            return _events[id];
        }
    }

    public List<T> GetAll() => new List<T>(_events.Values);
}
