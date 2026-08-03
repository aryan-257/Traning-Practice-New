namespace Q8_MiniORM;

public class MiniDb
{
    private Dictionary<string , object> _store = new Dictionary<string , object>();

    private string GetKey<T>(int id) => typeof(T).Name + "_" + id;

    public void Save<T>(T entity) where T : class
    {
        var idProp = typeof(T).GetProperty("Id");
        if(idProp == null) throw new Exception("Entity must have Id property");
        int id = (int)idProp.GetValue(entity)!;
        _store[GetKey<T>(id)] = entity;
        Console.WriteLine($"Saved {typeof(T).Name} with id {id}");
    }

    public T Get<T>(int id) where T : class
    {
        string key = GetKey<T>(id);
        if(!_store.ContainsKey(key))
            throw new Exception($"{typeof(T).Name} with id {id} not found");
        return (T)_store[key];
    }

    public void Delete<T>(int id) where T : class
    {
        string key = GetKey<T>(id);
        if(!_store.ContainsKey(key))
            throw new Exception($"{typeof(T).Name} with id {id} not found");
        _store.Remove(key);
        Console.WriteLine($"Deleted {typeof(T).Name} with id {id}");
    }

    public List<T> GetAll<T>() where T : class
    {
        var result = new List<T>();
        foreach(var entry in _store)
        {
            if(entry.Value is T val)
                result.Add(val);
        }
        return result;
    }
}
