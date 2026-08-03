using Q14_InventoryTracking;

var repo = new InventoryRepository();

repo.Add(new Product { SKU="P101" , Name="Laptop"  , Quantity=50  , ExpiryDate=DateTime.Now.AddYears(2)  });
repo.Add(new Product { SKU="P102" , Name="Mouse"   , Quantity=5   , ExpiryDate=DateTime.Now.AddYears(1)  });
repo.Add(new Product { SKU="P103" , Name="Milk"    , Quantity=8   , ExpiryDate=DateTime.Now.AddDays(-2)  });
repo.Add(new Product { SKU="P104" , Name="Bread"   , Quantity=3   , ExpiryDate=DateTime.Now.AddDays(-5)  });
repo.Add(new Product { SKU="P105" , Name="Keyboard", Quantity=200 , ExpiryDate=DateTime.Now.AddYears(3)  });

Console.WriteLine("Direct access P101 : " + repo["P101"].Name);

Console.WriteLine("\nLow stock items (< 10) :");
foreach(var p in repo.GetLowStockItems())
    Console.WriteLine($"  {p.SKU} | {p.Name} | Qty:{p.Quantity}");

Console.WriteLine("\nExpired items :");
foreach(var p in repo.GetExpiredItems())
    Console.WriteLine($"  {p.SKU} | {p.Name} | Expired:{p.ExpiryDate.ToShortDateString()}");
