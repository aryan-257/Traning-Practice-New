namespace OOP4_TicketManagement;

public class Ticket
{
    public int ticketId;
    public Passenger passenger;
    public Train train;
    public double amount;

    public Ticket(int id , Passenger p , Train t , double amt)
    {
        ticketId = id;
        passenger = p;
        train = t;
        amount = amt;
    }
}
