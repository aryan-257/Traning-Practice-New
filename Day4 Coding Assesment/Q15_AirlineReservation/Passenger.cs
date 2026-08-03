namespace Q15_AirlineReservation;

public class Passenger : Person
{
    public string seatClass;

    public Passenger(string n , string passport , string sclass) : base(n,passport)
    {
        seatClass = sclass;
    }
}
