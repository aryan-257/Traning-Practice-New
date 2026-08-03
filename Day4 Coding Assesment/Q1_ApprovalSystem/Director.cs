namespace Q1_ApprovalSystem;

public class Director : BaseApprover
{
    public Director(string name) : base(name) {}

    public override void ProcessRequest(ExpenseRequest req)
    {
        Console.WriteLine($"Director {approverName} approved Rs.{req.amount} for {req.purpose}");
    }
}
