using Q7_ShoppingCart;

var cart = new ShoppingCart<Product>();
cart.AddItem(new Product("Laptop" , 45000 , 1));
cart.AddItem(new Product("Mouse"  , 500   , 2));
cart.AddItem(new Product("Keyboard" , 1200 , 1));
cart.AddItem(new Product("Headphones" , 2000 , 1));
cart.AddItem(new Product("USB Hub" , 800 , 1));

double total    = cart.TotalPrice();
double discount = cart.ApplyDiscount(10);

var invoice = new
{
    ItemCount = cart.Count,
    Total     = total,
    Discount  = total - discount,
    FinalAmt  = discount
};

Console.WriteLine("=== Invoice Summary ===");
Console.WriteLine($"ItemCount = {invoice.ItemCount}");
Console.WriteLine($"Total     = {invoice.Total}");
Console.WriteLine($"Discount  = {invoice.Discount}");
Console.WriteLine($"FinalAmt  = {invoice.FinalAmt}");

Console.WriteLine("\nFirst item : " + cart[0].name);
