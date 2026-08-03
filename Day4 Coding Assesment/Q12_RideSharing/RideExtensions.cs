namespace Q12_RideSharing;

public static class RideExtensions
{
    public static double CalculateFare(this Ride ride)
    {
        return ride.distanceKm * ride.driver.vehicle.farePerKm;
    }

    public static double CalculateDistance(this Ride ride)
    {
        return ride.distanceKm;
    }
}
