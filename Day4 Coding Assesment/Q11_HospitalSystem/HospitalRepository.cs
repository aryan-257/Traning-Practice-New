namespace Q11_HospitalSystem;

public class HospitalRepository<T> where T : Person
{
    private Dictionary<string , T> _data = new Dictionary<string , T>();

    public void Add(T item) { _data[item.Id] = item; }

    public T this[string id]
    {
        get
        {
            if(!_data.ContainsKey(id)) throw new Exception("Not found : " + id);
            return _data[id];
        }
    }

    public List<T> GetAll() => new List<T>(_data.Values);
}
