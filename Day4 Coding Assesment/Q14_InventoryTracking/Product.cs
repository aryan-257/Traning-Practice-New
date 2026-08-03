namespace Q14_InventoryTracking;

public partial class Product
{
    public string SKU      { get; set; } = string.Empty;
    public string Name     { get; set; } = string.Empty;
    public int    Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }
}

public partial class Product
{
    public bool IsExpired() => DateTime.Now > ExpiryDate;
    public bool IsLowStock(int threshold = 10) => Quantity < threshold;
}
