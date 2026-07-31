using OOP4_TicketManagement;

var t1 = new Train("Rajdhani Express","12301");
var t2 = new Train("Shatabdi","12002");

var p1 = new Passenger("Aryan",101);
var p2 = new Passenger("Rahul",102);
var p3 = new Passenger("Priya",103);

TicketManager mgr = new TicketManager();
mgr.BookTicket(new Ticket(1,p1,t1,500));
mgr.BookTicket(new Ticket(2,p2,t1,500));
mgr.BookTicket(new Ticket(3,p1,t2,800));
mgr.BookTicket(new Ticket(4,p3,t2,800));

Console.WriteLine("Total amount collected : Rs." + mgr.TotalAmountCollected());

Console.WriteLine("\nTickets for Aryan (id 101) :");
foreach(var t in mgr.GetTicketsByPassenger(101))
    Console.WriteLine(" - Ticket#" + t.ticketId + " Train: " + t.train.trainName);

Console.WriteLine("\nPassengers on Rajdhani (12301) :");
foreach(var p in mgr.GetPassengersByTrain("12301"))
    Console.WriteLine(" - " + p.name);
