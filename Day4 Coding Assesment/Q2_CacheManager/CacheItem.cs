namespace Q2_CacheManager;

public class CacheItem<T>
{
    public T value;
    public DateTime addedAt;
    public TimeSpan expiry;

    public CacheItem(T val , TimeSpan exp)
    {
        value = val;
        addedAt = DateTime.Now;
        expiry = exp;
    }

    public bool IsExpired()
    {
        return DateTime.Now > addedAt + expiry;
    }
}
