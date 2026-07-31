using OOP10_MarineCompany;

MarineCompany company = new MarineCompany("SeaWay Marine");

var cruise1 = new CruiseShip("Queen Mary","C001","Maldives");
var cruise2 = new CruiseShip("Royal Princess","C002","Dubai");
var cargo1 = new CargoShip("Iron Hawk","G001",5000);

company.AddShip(cruise1);
company.AddShip(cruise2);
company.AddShip(cargo1);

company.AddBooking(new Booking("Aryan",cruise1,15000,"Mumbai","Maldives"));
company.AddBooking(new Booking("Priya",cruise1,15000,"Mumbai","Maldives"));
company.AddBooking(new Booking("Rahul",cruise2,20000,"Chennai","Dubai"));
company.AddBooking(new Booking("ShipCo Ltd",cargo1,50000,"Mumbai","Singapore"));

Console.WriteLine("Total amount collected : Rs." + company.TotalAmountCollected());

Console.WriteLine("\nAmount per ship :");
foreach(var entry in company.AmountPerShip())
    Console.WriteLine(" - " + entry.Key + " : Rs." + entry.Value);

Console.WriteLine("\nCustomers on Queen Mary (C001) :");
foreach(var b in company.GetCustomersForCruise("C001"))
    Console.WriteLine(" - " + b.customerName + " from " + b.fromPlace + " to " + b.toPlace);
