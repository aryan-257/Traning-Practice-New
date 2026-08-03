namespace Q14_InventoryTracking;

public static class InventoryExtensions
{
    public static List<Product> GetLowStockItems(this InventoryRepository repo , int threshold = 10)
    {
        var result = new List<Product>();
        foreach(var p in repo.GetAll())
        {
            if(p.IsLowStock(threshold))
                result.Add(p);
        }
        return result;
    }

    public static List<Product> GetExpiredItems(this InventoryRepository repo)
    {
        var result = new List<Product>();
        foreach(var p in repo.GetAll())
        {
            if(p.IsExpired())
                result.Add(p);
        }
        return result;
    }
}
