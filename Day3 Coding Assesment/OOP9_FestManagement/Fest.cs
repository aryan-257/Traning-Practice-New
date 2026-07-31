namespace OOP9_FestManagement;

public class Fest
{
    public string festName;
    public List<Registration> registrations = new List<Registration>();

    public Fest(string name)
    {
        festName = name;
    }

    public void AddRegistration(Registration r)
    {
        registrations.Add(r);
    }

    public double TotalAmountCollected()
    {
        double total = 0;
        foreach(var r in registrations)
            total += r.amountPaid;
        return total;
    }

    public Dictionary<string,int> ParticipantsPerEvent()
    {
        Dictionary<string,int> res = new Dictionary<string,int>();
        foreach(var r in registrations)
        {
            if(!res.ContainsKey(r.evnt.eventName))
                res[r.evnt.eventName] = 0;
            res[r.evnt.eventName]++;
        }
        return res;
    }

    public Dictionary<string,double> AmountPerEvent()
    {
        Dictionary<string,double> res = new Dictionary<string,double>();
        foreach(var r in registrations)
        {
            if(!res.ContainsKey(r.evnt.eventName))
                res[r.evnt.eventName] = 0;
            res[r.evnt.eventName] += r.amountPaid;
        }
        return res;
    }
}
