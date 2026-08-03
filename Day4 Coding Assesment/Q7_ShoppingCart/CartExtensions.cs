namespace Q7_ShoppingCart;

public static class CartExtensions
{
    public static double ApplyDiscount<T>(this ShoppingCart<T> cart , double discountPercent) where T : Product
    {
        double total = cart.TotalPrice();
        return total - (total * discountPercent / 100);
    }
}
