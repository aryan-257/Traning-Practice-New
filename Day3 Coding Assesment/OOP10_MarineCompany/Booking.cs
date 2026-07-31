namespace OOP10_MarineCompany;

public class Booking
{
    public string customerName;
    public Ship ship;
    public double amountPaid;
    public string fromPlace;
    public string toPlace;

    public Booking(string cname , Ship s , double amt , string from , string to)
    {
        customerName = cname;
        ship = s;
        amountPaid = amt;
        fromPlace = from;
        toPlace = to;
    }
}
