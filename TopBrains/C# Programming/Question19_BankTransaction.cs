namespace CodingProblems;

public class Question19_BankTransaction
{
    public static int GetFinalBalance(int initialBalance, int[] transactions)
    {
        int balance = initialBalance;

        foreach (int transaction in transactions)
        {
            if (transaction >= 0)
            {
                balance += transaction;
            }
            else
            {
                if (balance + transaction >= 0)
                    balance += transaction;
            }
        }

        return balance;
    }
}
