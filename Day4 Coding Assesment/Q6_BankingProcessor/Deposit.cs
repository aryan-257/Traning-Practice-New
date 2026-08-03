namespace Banking.Deposit;

using Banking;

public sealed class DepositTransaction : ITransaction
{
    public string TransactionId { get; } = Guid.NewGuid().ToString().Substring(0,8);
    public double Amount { get; }

    public DepositTransaction(double amt)
    {
        Amount = amt;
    }

    public bool IsValid() => Amount > 0;

    public void Execute(BankAccount account)
    {
        account.Deposit(Amount);
        Console.WriteLine($"[Deposit] {TransactionId} : +{Amount}");
    }

    public void Rollback(BankAccount account)
    {
        account.Withdraw(Amount);
        Console.WriteLine($"[Rollback Deposit] {TransactionId} : -{Amount}");
    }
}
