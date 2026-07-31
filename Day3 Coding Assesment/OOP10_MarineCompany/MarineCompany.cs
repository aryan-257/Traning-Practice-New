namespace OOP10_MarineCompany;

public class MarineCompany
{
    public string companyName;
    public List<Ship> ships = new List<Ship>();
    public List<Booking> bookings = new List<Booking>();

    public MarineCompany(string name)
    {
        companyName = name;
    }

    public void AddShip(Ship s) { ships.Add(s); }

    public void AddBooking(Booking b) { bookings.Add(b); }

    public double TotalAmountCollected()
    {
        double total = 0;
        foreach(var b in bookings)
            total += b.amountPaid;
        return total;
    }

    public Dictionary<string,double> AmountPerShip()
    {
        Dictionary<string,double> res = new Dictionary<string,double>();
        foreach(var b in bookings)
        {
            if(!res.ContainsKey(b.ship.shipName))
                res[b.ship.shipName] = 0;
            res[b.ship.shipName] += b.amountPaid;
        }
        return res;
    }

    public List<Booking> GetCustomersForCruise(string shipId)
    {
        List<Booking> res = new List<Booking>();
        foreach(var b in bookings)
        {
            if(b.ship.shipId == shipId && b.ship.GetShipType() == "Cruise")
                res.Add(b);
        }
        return res;
    }
}
