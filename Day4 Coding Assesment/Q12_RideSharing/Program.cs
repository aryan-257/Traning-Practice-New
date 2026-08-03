using Q12_RideSharing;

var d1 = new Driver("Ravi","D01", new Car("MH01","Swift"));
var d2 = new Driver("Suresh","D02", new Bike("MH02","Activa"));

var r1 = new Rider("Aryan","R01");
var r2 = new Rider("Priya","R02");

d1.isAvailable = false;
d2.isAvailable = false;

var ride1 = new Ride("RIDE001" , d1 , r1 , 12.5);
var ride2 = new Ride("RIDE002" , d2 , r2 , 8.0);

Console.WriteLine($"Ride1 : {ride1.rider.name} with {ride1.driver.name}");
Console.WriteLine($"  Distance : {ride1.CalculateDistance()} km");
Console.WriteLine($"  Fare     : Rs.{ride1.CalculateFare()}");

Console.WriteLine($"\nRide2 : {ride2.rider.name} with {ride2.driver.name}");
Console.WriteLine($"  Distance : {ride2.CalculateDistance()} km");
Console.WriteLine($"  Fare     : Rs.{ride2.CalculateFare()}");

ride1.Complete();
Console.WriteLine($"\nAfter completing ride1, driver {d1.name} available : {d1.isAvailable}");
