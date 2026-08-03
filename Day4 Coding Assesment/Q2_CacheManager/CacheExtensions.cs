namespace Q2_CacheManager;

public static class CacheExtensions
{
    public static List<string> GetAllKeys<T>(this CacheManager<T> cache)
    {
        return new List<string>(cache.GetStore().Keys);
    }

    public static int CountExpiredItems<T>(this CacheManager<T> cache)
    {
        int count = 0;
        foreach(var item in cache.GetStore().Values)
        {
            if(item.IsExpired())
                count++;
        }
        return count;
    }
}
