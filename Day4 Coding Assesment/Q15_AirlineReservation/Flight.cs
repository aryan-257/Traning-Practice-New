namespace Q15_AirlineReservation;

public class Flight : IBookable , ICancelable
{
    public string flightNo;
    public string from;
    public string to;
    public int    totalSeats;
    public List<Passenger> passengers = new List<Passenger>();

    public Flight(string no , string f , string t , int seats)
    {
        flightNo = no; from = f; to = t; totalSeats = seats;
    }

    public void Book(Passenger p)
    {
        if(passengers.Count >= totalSeats)
        {
            Console.WriteLine("Flight full. Adding to waitlist : " + p.name);
            return;
        }
        passengers.Add(p);
        Console.WriteLine($"Booked {p.name} on flight {flightNo}");
    }

    public void Cancel(string passportNo)
    {
        var p = passengers.Find(x => x.passportNo == passportNo);
        if(p == null) { Console.WriteLine("Passenger not found"); return; }
        passengers.Remove(p);
        Console.WriteLine($"Cancelled booking for {p.name}");
    }

    public void GenerateBoardingPass(string passportNo)
    {
        var p = passengers.Find(x => x.passportNo == passportNo);
        if(p == null) { Console.WriteLine("Passenger not found"); return; }
        Console.WriteLine($"\n=== Boarding Pass ===");
        Console.WriteLine($"  Name     : {p.name}");
        Console.WriteLine($"  Flight   : {flightNo}");
        Console.WriteLine($"  From     : {from} -> {to}");
        Console.WriteLine($"  Class    : {p.seatClass}");
        Console.WriteLine($"  Passport : {p.passportNo}");
    }
}
