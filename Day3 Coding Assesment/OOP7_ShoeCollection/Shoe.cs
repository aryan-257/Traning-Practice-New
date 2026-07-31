namespace OOP7_ShoeCollection;

public class Shoe
{
    public string brand;
    public string kind;
    public double price;
    public string shoeId;

    public Shoe(string id , string br , string k , double pr)
    {
        shoeId = id;
        brand = br;
        kind = k;
        price = pr;
    }
}
