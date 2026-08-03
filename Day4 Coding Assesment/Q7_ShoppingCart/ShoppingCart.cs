namespace Q7_ShoppingCart;

public class ShoppingCart<T> where T : Product
{
    private List<T> _items = new List<T>();

    public void AddItem(T item) { _items.Add(item); }

    public void RemoveItem(string name)
    {
        var item = _items.Find(x => x.name == name);
        if(item != null) _items.Remove(item);
    }

    public double TotalPrice()
    {
        double total = 0;
        foreach(var item in _items)
            total += item.price * item.qty;
        return total;
    }

    public T this[int index] => _items[index];

    public List<T> GetItems() => _items;

    public int Count => _items.Count;
}
