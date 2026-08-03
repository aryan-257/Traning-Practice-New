namespace Q12_RideSharing;

public class Driver
{
    public string name;
    public string driverId;
    public bool isAvailable;
    public Vehicle vehicle;

    public Driver(string n , string id , Vehicle v)
    {
        name = n; driverId = id; vehicle = v; isAvailable = true;
    }
}
