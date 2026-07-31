using OOP7_ShoeCollection;

ShoeHouse house = new ShoeHouse();
var sh1 = new Shoe("S001","Nike","Sports",3500);
var sh2 = new Shoe("S002","Adidas","Casual",2500);
var sh3 = new Shoe("S003","Puma","Sports",3000);
var sh4 = new Shoe("S004","Nike","Formal",4000);

house.AddShoe(sh1);
house.AddShoe(sh2);
house.AddShoe(sh3);
house.AddShoe(sh4);

var today = DateTime.Today;
house.AddTransaction(new Transaction("Aryan",sh1,"Buy",today));
house.AddTransaction(new Transaction("Aryan",sh2,"Replace",today));
house.AddTransaction(new Transaction("Rahul",sh1,"Buy",today));
house.AddTransaction(new Transaction("Priya",sh3,"Buy",today));

Console.WriteLine("Shoe count by kind :");
foreach(var entry in house.ShoeCountByKind())
    Console.WriteLine(" - " + entry.Key + " : " + entry.Value);

Console.WriteLine("\nTransaction history for Aryan :");
foreach(var t in house.GetCustomerHistory("Aryan"))
    Console.WriteLine(" - " + t.transactionType + " : " + t.shoe.brand + " " + t.shoe.kind);

Console.WriteLine("\nCustomers who bought shoe S001 :");
foreach(var c in house.GetCustomerWhoBoought("S001"))
    Console.WriteLine(" - " + c);
