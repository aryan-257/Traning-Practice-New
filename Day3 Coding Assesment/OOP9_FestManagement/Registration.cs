namespace OOP9_FestManagement;

public class Registration
{
    public Participant participant;
    public Event evnt;
    public double amountPaid;

    public Registration(Participant p , Event e)
    {
        participant = p;
        evnt = e;
        amountPaid = e.entryFee;
    }
}
