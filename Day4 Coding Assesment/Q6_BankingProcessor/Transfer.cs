namespace Banking.Transfer;

using Banking;

public sealed class WithdrawTransaction : ITransaction
{
    public string TransactionId { get; } = Guid.NewGuid().ToString().Substring(0,8);
    public double Amount { get; }

    public WithdrawTransaction(double amt)
    {
        Amount = amt;
    }

    public bool IsValid() => Amount > 0;

    public void Execute(BankAccount account)
    {
        account.Withdraw(Amount);
        Console.WriteLine($"[Withdraw] {TransactionId} : -{Amount}");
    }

    public void Rollback(BankAccount account)
    {
        account.Deposit(Amount);
        Console.WriteLine($"[Rollback Withdraw] {TransactionId} : +{Amount}");
    }
}
