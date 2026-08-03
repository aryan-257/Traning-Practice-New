namespace Q14_InventoryTracking;

public class InventoryRepository
{
    private Dictionary<string , Product> _store = new Dictionary<string , Product>();

    public void Add(Product p) { _store[p.SKU] = p; }

    public Product this[string sku]
    {
        get
        {
            if(!_store.ContainsKey(sku)) throw new Exception("SKU not found : " + sku);
            return _store[sku];
        }
    }

    public List<Product> GetAll() => new List<Product>(_store.Values);
}
