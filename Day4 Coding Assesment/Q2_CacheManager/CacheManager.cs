namespace Q2_CacheManager;

public class CacheManager<T>
{
    private Dictionary<string , CacheItem<T>> _store = new Dictionary<string , CacheItem<T>>();

    public void Add(string key , T value , TimeSpan? expiry = null)
    {
        _store[key] = new CacheItem<T>(value , expiry ?? TimeSpan.FromMinutes(10));
    }

    public void Remove(string key)
    {
        if(!_store.ContainsKey(key))
            throw new InvalidCacheKeyException(key);
        _store.Remove(key);
    }

    public T GetByKey(string key)
    {
        if(!_store.ContainsKey(key))
            throw new InvalidCacheKeyException(key);
        return _store[key].value;
    }

    public void Clear()
    {
        _store.Clear();
    }

    public T this[string key]
    {
        get { return GetByKey(key); }
    }

    public Dictionary<string , CacheItem<T>> GetStore() => _store;
}
