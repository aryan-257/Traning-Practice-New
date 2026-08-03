namespace Banking;

public interface ITransaction
{
    string TransactionId { get; }
    double Amount { get; }
    bool IsValid();
    void Execute(BankAccount account);
    void Rollback(BankAccount account);
}
