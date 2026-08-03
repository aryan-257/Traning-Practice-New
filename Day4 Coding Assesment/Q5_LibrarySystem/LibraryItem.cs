namespace Q5_LibrarySystem;

public abstract class LibraryItem
{
    public string title;
    public string author;
    public bool isAvailable;

    public LibraryItem(string t , string a)
    {
        title = t;
        author = a;
        isAvailable = true;
    }

    public abstract string GetItemType();
}

public class Book : LibraryItem
{
    public string isbn;
    public Book(string t , string a , string isbn) : base(t,a) { this.isbn = isbn; }
    public override string GetItemType() => "Book";
}

public class Magazine : LibraryItem
{
    public int issueNo;
    public Magazine(string t , string a , int issue) : base(t,a) { issueNo = issue; }
    public override string GetItemType() => "Magazine";
}

public class Journal : LibraryItem
{
    public string field;
    public Journal(string t , string a , string f) : base(t,a) { field = f; }
    public override string GetItemType() => "Journal";
}
