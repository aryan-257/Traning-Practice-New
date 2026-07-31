namespace OOP4_TicketManagement;

public class TicketManager
{
    public List<Ticket> tickets = new List<Ticket>();

    public void BookTicket(Ticket t)
    {
        tickets.Add(t);
    }

    public double TotalAmountCollected()
    {
        double total = 0;
        foreach(var t in tickets)
            total += t.amount;
        return total;
    }

    public List<Ticket> GetTicketsByPassenger(int passengerId)
    {
        List<Ticket> res = new List<Ticket>();
        foreach(var t in tickets)
        {
            if(t.passenger.passengerId == passengerId)
                res.Add(t);
        }
        return res;
    }

    public List<Passenger> GetPassengersByTrain(string trainNo)
    {
        List<Passenger> res = new List<Passenger>();
        foreach(var t in tickets)
        {
            if(t.train.trainNo == trainNo)
                res.Add(t.passenger);
        }
        return res;
    }
}
