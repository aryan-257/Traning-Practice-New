namespace Q12_RideSharing;

public sealed class Ride
{
    public string rideId;
    public Driver driver;
    public Rider  rider;
    public double distanceKm;
    public bool   isCompleted;

    public Ride(string id , Driver d , Rider r , double dist)
    {
        rideId = id; driver = d; rider = r; distanceKm = dist; isCompleted = false;
    }

    public void Complete()
    {
        isCompleted = true;
        driver.isAvailable = true;
    }
}
