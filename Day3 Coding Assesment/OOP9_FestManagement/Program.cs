using OOP9_FestManagement;

Fest fest = new Fest("TechFest 2026");

var dance = new Event("Dance",500);
var singing = new Event("Singing",300);
var coding = new Event("Coding",400);

var p1 = new Participant("Aryan");
var p2 = new Participant("TeamAlpha",true);
var p3 = new Participant("Priya");
var p4 = new Participant("Rahul");

fest.AddRegistration(new Registration(p1,dance));
fest.AddRegistration(new Registration(p1,coding));
fest.AddRegistration(new Registration(p2,dance));
fest.AddRegistration(new Registration(p3,singing));
fest.AddRegistration(new Registration(p4,coding));
fest.AddRegistration(new Registration(p4,singing));

Console.WriteLine("Total amount collected : Rs." + fest.TotalAmountCollected());

Console.WriteLine("\nParticipants per event :");
foreach(var entry in fest.ParticipantsPerEvent())
    Console.WriteLine(" - " + entry.Key + " : " + entry.Value + " participants");

Console.WriteLine("\nAmount collected per event :");
foreach(var entry in fest.AmountPerEvent())
    Console.WriteLine(" - " + entry.Key + " : Rs." + entry.Value);
