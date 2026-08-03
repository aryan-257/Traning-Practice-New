namespace Q8_MiniORM;

public partial class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Salary { get; set; }
}

public partial class Employee
{
    public string GetDisplayName() => $"[{Id}] {Name}";
}

public class Order
{
    public int Id { get; set; }
    public string Product { get; set; } = string.Empty;
    public double Amount { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}
