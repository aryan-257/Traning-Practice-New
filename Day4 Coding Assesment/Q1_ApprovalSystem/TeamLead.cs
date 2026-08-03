namespace Q1_ApprovalSystem;

public class TeamLead : BaseApprover
{
    public TeamLead(string name) : base(name) {}

    public override void ProcessRequest(ExpenseRequest req)
    {
        if(req.amount <= 10000)
            Console.WriteLine($"TeamLead {approverName} approved Rs.{req.amount} for {req.purpose}");
        else if(nextApprover != null)
            nextApprover.ProcessRequest(req);
        else
            Console.WriteLine("No one could approve : " + req.purpose);
    }
}
