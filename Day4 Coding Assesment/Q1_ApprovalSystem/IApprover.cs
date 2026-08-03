namespace Q1_ApprovalSystem;

public interface IApprover
{
    void SetNext(IApprover next);
    void ProcessRequest(ExpenseRequest req);
}
