using Q8_MiniORM;

var db = new MiniDb();

db.Save(new Employee { Id=1 , Name="Aryan"  , Salary=50000 });
db.Save(new Employee { Id=2 , Name="Sneha"  , Salary=60000 });
db.Save(new Order    { Id=1 , Product="Laptop" , Amount=45000 });
db.Save(new Customer { Id=1 , Name="Rahul" });

var emp = db.Get<Employee>(1);
Console.WriteLine("\nFetched : " + emp.GetDisplayName());

db.Delete<Order>(1);

var allEmps = db.GetAll<Employee>();
Console.WriteLine("\nAll employees :");
foreach(var e in allEmps)
    Console.WriteLine(" - " + e.GetDisplayName() + " Salary=" + e.Salary);
