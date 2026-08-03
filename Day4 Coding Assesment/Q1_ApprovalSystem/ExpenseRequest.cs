namespace Q1_ApprovalSystem;

public class ExpenseRequest
{
    public string purpose;
    public double amount;

    public ExpenseRequest(string p , double amt)
    {
        purpose = p;
        amount = amt;
    }
}
