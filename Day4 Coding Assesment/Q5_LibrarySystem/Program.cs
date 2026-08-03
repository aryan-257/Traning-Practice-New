using Q5_LibrarySystem;

var books = new GenericRepository<Book>();
books.Add(new Book("Clean Code","Robert Martin","ISBN001"));
books.Add(new Book("C# in Depth","Jon Skeet","ISBN002"));
books.Add(new Book("Design Patterns","GoF","ISBN003"));

books.Borrow("Clean Code");

Console.WriteLine("Available books :");
foreach(var b in books.GetAvailableBooks())
    Console.WriteLine(" - " + b.title + " by " + b.author);

Console.WriteLine("\nDirect access : " + books["C# in Depth"].title);

books.Return("Clean Code");
Console.WriteLine("\nAfter return, available : " + books.GetAvailableBooks().Count);

var journals = new GenericRepository<Journal>();
journals.Add(new Journal("AI Research","Dr. Kumar","AI"));
journals.Add(new Journal("Bio Tech Today","Dr. Singh","Biology"));
Console.WriteLine("\nAll journals : " + journals.GetAll().Count);
