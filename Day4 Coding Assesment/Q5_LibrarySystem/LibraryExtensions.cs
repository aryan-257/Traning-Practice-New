namespace Q5_LibrarySystem;

public static class LibraryExtensions
{
    public static List<T> GetAvailableBooks<T>(this GenericRepository<T> repo) where T : LibraryItem
    {
        var result = new List<T>();
        foreach(var item in repo.GetAll())
        {
            if(item.isAvailable)
                result.Add(item);
        }
        return result;
    }
}
