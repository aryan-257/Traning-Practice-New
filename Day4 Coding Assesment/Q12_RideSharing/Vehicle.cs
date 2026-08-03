namespace Q12_RideSharing;

public abstract class Vehicle
{
    public string vehicleNo;
    public string model;
    public double farePerKm;

    public Vehicle(string no , string mod , double fare)
    {
        vehicleNo = no; model = mod; farePerKm = fare;
    }

    public abstract string GetVehicleType();
}

public class Car : Vehicle
{
    public Car(string no , string mod) : base(no , mod , 12) {}
    public override string GetVehicleType() => "Car";
}

public class Bike : Vehicle
{
    public Bike(string no , string mod) : base(no , mod , 6) {}
    public override string GetVehicleType() => "Bike";
}
