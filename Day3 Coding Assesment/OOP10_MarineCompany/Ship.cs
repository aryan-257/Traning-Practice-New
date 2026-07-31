namespace OOP10_MarineCompany;

public abstract class Ship
{
    public string shipName;
    public string shipId;

    public Ship(string name , string id)
    {
        shipName = name;
        shipId = id;
    }

    public abstract string GetShipType();
}

public class CruiseShip : Ship
{
    public string destination;

    public CruiseShip(string name , string id , string dest) : base(name,id)
    {
        destination = dest;
    }

    public override string GetShipType() => "Cruise";
}

public class CargoShip : Ship
{
    public double cargoWeightLimit;

    public CargoShip(string name , string id , double weightLimit) : base(name,id)
    {
        cargoWeightLimit = weightLimit;
    }

    public override string GetShipType() => "Cargo";
}
