using Banking;
using Banking.Deposit;
using Banking.Transfer;

var account = new BankAccount("ACC001" , 10000);
var history = new Stack<ITransaction>();

void Process(ITransaction txn)
{
    if(!txn.IsValid()) { Console.WriteLine("Invalid transaction"); return; }
    txn.Execute(account);
    history.Push(txn);
}

Process(new DepositTransaction(5000));
Process(new WithdrawTransaction(3000));
Process(new DepositTransaction(2000));

Console.WriteLine("\nBalance : " + account.Balance);

Console.WriteLine("\nUndo last transaction :");
if(history.Count > 0)
    history.Pop().Rollback(account);

Console.WriteLine("Balance after undo : " + account.Balance);

Console.WriteLine("\nTransaction Log :");
foreach(var log in account.transactionLog)
    Console.WriteLine(" " + log);
