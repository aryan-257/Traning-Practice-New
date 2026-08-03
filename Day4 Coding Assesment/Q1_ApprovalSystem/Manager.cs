namespace Q1_ApprovalSystem;

public class Manager : BaseApprover
{
    public Manager(string name) : base(name) {}

    public override void ProcessRequest(ExpenseRequest req)
    {
        if(req.amount <= 50000)
            Console.WriteLine($"Manager {approverName} approved Rs.{req.amount} for {req.purpose}");
        else if(nextApprover != null)
            nextApprover.ProcessRequest(req);
        else
            Console.WriteLine("No one could approve : " + req.purpose);
    }
}
