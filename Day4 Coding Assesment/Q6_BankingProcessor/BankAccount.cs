namespace Banking;

public class BankAccount
{
    public string accountNo;
    private double _balance;

    public double Balance
    {
        get { return _balance; }
        private set { _balance = value; }
    }

    public List<string> transactionLog = new List<string>();

    public BankAccount(string no , double initialBalance)
    {
        accountNo = no;
        _balance = initialBalance;
    }

    public void Deposit(double amt)
    {
        _balance += amt;
        transactionLog.Add($"Deposited {amt} | Balance : {_balance}");
    }

    public void Withdraw(double amt)
    {
        if(amt > _balance)
            throw new Exception("Insufficient balance");
        _balance -= amt;
        transactionLog.Add($"Withdrew {amt} | Balance : {_balance}");
    }
}
