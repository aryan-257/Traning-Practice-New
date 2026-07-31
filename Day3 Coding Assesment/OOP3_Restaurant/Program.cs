using OOP3_Restaurant;

Restaurant r = new Restaurant("Spice Garden","Bangalore");

r.AddItem(new MenuItem("Soup",150,"Starter"));
r.AddItem(new MenuItem("Salad",120,"Starter",true));
r.AddItem(new MenuItem("Butter Chicken",350,"Main Course"));
r.AddItem(new MenuItem("Paneer Tikka",300,"Main Course",true));
r.AddItem(new MenuItem("Dal Makhani",250,"Main Course"));
r.AddItem(new MenuItem("Gulab Jamun",100,"Dessert",true));
r.AddItem(new MenuItem("Ice Cream",120,"Dessert"));

Console.WriteLine("Total menu items : " + r.TotalMenuItems());

Console.WriteLine("\nMain Course items :");
foreach(var item in r.GetByCategory("Main Course"))
    Console.WriteLine(" - " + item.itemName + " Rs." + item.price);

Console.WriteLine("\nSpecial Discount Menu (30% off) :");
foreach(var item in r.GetSpecialMenus())
    Console.WriteLine(" - " + item.itemName + " Original: " + item.price + " After Discount: " + item.GetFinalPrice());
