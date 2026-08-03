namespace Q1_ApprovalSystem;

public abstract class BaseApprover : IApprover
{
    protected IApprover? nextApprover;
    public string approverName;

    public BaseApprover(string name)
    {
        approverName = name;
    }

    public void SetNext(IApprover next)
    {
        nextApprover = next;
    }

    public abstract void ProcessRequest(ExpenseRequest req);
}
