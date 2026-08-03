namespace Q5_LibrarySystem;

public class GenericRepository<T> where T : LibraryItem
{
    private List<T> _items = new List<T>();

    public void Add(T item) { _items.Add(item); }

    public void Remove(string title)
    {
        var item = _items.Find(x => x.title == title);
        if(item != null) _items.Remove(item);
    }

    public T this[string title]
    {
        get
        {
            var item = _items.Find(x => x.title == title);
            if(item == null) throw new Exception("Item not found : " + title);
            return item;
        }
    }

    public List<T> GetAll() => _items;

    public void Borrow(string title)
    {
        var item = this[title];
        if(!item.isAvailable) throw new Exception("Item not available");
        item.isAvailable = false;
    }

    public void Return(string title)
    {
        var item = this[title];
        item.isAvailable = true;
    }
}
