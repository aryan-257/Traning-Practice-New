using Q15_AirlineReservation;

var repo = new FlightRepository();
repo.Add(new Flight("AI101" , "Mumbai" , "Delhi"   , 3));
repo.Add(new Flight("AI202" , "Delhi"  , "Bangalore", 2));

repo["AI101"].Book(new Passenger("Aryan"  , "P001" , "Economy"));
repo["AI101"].Book(new Passenger("Sneha"  , "P002" , "Business"));
repo["AI101"].Book(new Passenger("Rahul"  , "P003" , "Premium"));
repo["AI101"].Book(new Passenger("Priya"  , "P004" , "Economy"));

repo["AI202"].Book(new Passenger("Vikram" , "P005" , "Business"));

Console.WriteLine("\nAI101 available seats : " + repo["AI101"].GetAvailableSeats());
Console.WriteLine("Ticket price Economy  : Rs." + repo["AI101"].CalculateTicketPrice("Economy"));
Console.WriteLine("Ticket price Business : Rs." + repo["AI101"].CalculateTicketPrice("Business"));

repo["AI101"].GenerateBoardingPass("P001");

repo["AI101"].Cancel("P002");
Console.WriteLine("\nAfter cancel, available seats : " + repo["AI101"].GetAvailableSeats());
