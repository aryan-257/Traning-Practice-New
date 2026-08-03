namespace Q2_CacheManager;

public class InvalidCacheKeyException : Exception
{
    public InvalidCacheKeyException(string key) : base("Invalid cache key : " + key)
    {
    }
}
