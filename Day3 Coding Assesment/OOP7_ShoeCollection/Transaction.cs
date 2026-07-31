namespace OOP7_ShoeCollection;

public class Transaction
{
    public string customerName;
    public Shoe shoe;
    public string transactionType;
    public DateTime date;

    public Transaction(string cname , Shoe s , string type , DateTime d)
    {
        customerName = cname;
        shoe = s;
        transactionType = type;
        date = d;
    }
}
