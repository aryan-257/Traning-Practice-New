namespace OOP7_ShoeCollection;

public class ShoeHouse
{
    public List<Shoe> shoes = new List<Shoe>();
    public List<Transaction> transactions = new List<Transaction>();

    public void AddShoe(Shoe s) { shoes.Add(s); }

    public void AddTransaction(Transaction t) { transactions.Add(t); }

    public Dictionary<string,int> ShoeCountByKind()
    {
        Dictionary<string,int> res = new Dictionary<string,int>();
        foreach(var s in shoes)
        {
            if(!res.ContainsKey(s.kind))
                res[s.kind] = 0;
            res[s.kind]++;
        }
        return res;
    }

    public List<Transaction> GetCustomerHistory(string customerName)
    {
        List<Transaction> res = new List<Transaction>();
        foreach(var t in transactions)
        {
            if(t.customerName.ToLower() == customerName.ToLower())
                res.Add(t);
        }
        return res;
    }

    public List<string> GetCustomerWhoBoought(string shoeId)
    {
        List<string> res = new List<string>();
        foreach(var t in transactions)
        {
            if(t.shoe.shoeId == shoeId && t.transactionType == "Buy")
                res.Add(t.customerName);
        }
        return res;
    }
}
