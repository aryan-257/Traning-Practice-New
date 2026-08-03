namespace Q15_AirlineReservation;

public class FlightRepository
{
    private Dictionary<string , Flight> _flights = new Dictionary<string , Flight>();

    public void Add(Flight f) { _flights[f.flightNo] = f; }

    public Flight this[string flightNo]
    {
        get
        {
            if(!_flights.ContainsKey(flightNo)) throw new Exception("Flight not found : " + flightNo);
            return _flights[flightNo];
        }
    }

    public List<Flight> GetAll() => new List<Flight>(_flights.Values);
}
