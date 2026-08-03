namespace Q15_AirlineReservation;

public static class FlightExtensions
{
    public static int GetAvailableSeats(this Flight flight)
    {
        return flight.totalSeats - flight.passengers.Count;
    }

    public static double CalculateTicketPrice(this Flight flight , string seatClass)
    {
        if(seatClass == "Business") return 15000;
        if(seatClass == "Premium")  return 10000;
        return 5000;
    }
}
