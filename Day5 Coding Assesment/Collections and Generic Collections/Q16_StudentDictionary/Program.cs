using Q16_StudentDictionary;

StudentManager mgr = new StudentManager();

mgr.Add(new Student(1 , "Aryan" , 88.5));
mgr.Add(new Student(2 , "Sneha" , 92.0));
mgr.Add(new Student(3 , "Rahul" , 75.0));
mgr.Add(new Student(1 , "Duplicate" , 50));

Console.WriteLine("\nAll students :");
mgr.DisplayAll();

mgr.Update(2 , "Sneha Sharma" , 95.0);

Console.WriteLine("\nAfter update :");
mgr.DisplayAll();

mgr.Delete(3);
Console.WriteLine("\nAfter delete :");
mgr.DisplayAll();
