namespace Q17_LibraryManagement;

public class Library
{
    private List<Book> books = new List<Book>();
    private int nextId = 1;

    public void AddBook(string title, string publisher, double price)
    {
        books.Add(new Book { Id = nextId++, Title = title, Publisher = publisher, Price = price });
        Console.WriteLine("Book added successfully.");
    }

    public void UpdateBook(int id, string title, string publisher, double price)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        book.Title = title;
        book.Publisher = publisher;
        book.Price = price;
        Console.WriteLine("Book updated successfully.");
    }

    public void DeleteBook(int id)
    {
        var book = books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        books.Remove(book);
        Console.WriteLine("Book deleted successfully.");
    }

    public void ViewAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }
        foreach (var b in books)
            Console.WriteLine($"ID: {b.Id} | Title: {b.Title} | Publisher: {b.Publisher} | Price: {b.Price}");
    }

    public void SearchByName(string name)
    {
        var result = books.Where(b => b.Title.ToLower().Contains(name.ToLower())).ToList();
        if (result.Count == 0)
            Console.WriteLine("No matching books found.");
        else
            result.ForEach(b => Console.WriteLine($"ID: {b.Id} | Title: {b.Title} | Publisher: {b.Publisher} | Price: {b.Price}"));
    }

    public void SearchByPublisher(string publisher)
    {
        var result = books.Where(b => b.Publisher.ToLower().Contains(publisher.ToLower())).ToList();
        if (result.Count == 0)
            Console.WriteLine("No matching books found.");
        else
            result.ForEach(b => Console.WriteLine($"ID: {b.Id} | Title: {b.Title} | Publisher: {b.Publisher} | Price: {b.Price}"));
    }

    public void ViewHighestPricedBook()
    {
        if (books.Count == 0) { Console.WriteLine("No books available."); return; }
        var book = books.OrderByDescending(b => b.Price).First();
        Console.WriteLine($"Highest: ID: {book.Id} | Title: {book.Title} | Price: {book.Price}");
    }

    public void ViewLowestPricedBook()
    {
        if (books.Count == 0) { Console.WriteLine("No books available."); return; }
        var book = books.OrderBy(b => b.Price).First();
        Console.WriteLine($"Lowest: ID: {book.Id} | Title: {book.Title} | Price: {book.Price}");
    }
}
