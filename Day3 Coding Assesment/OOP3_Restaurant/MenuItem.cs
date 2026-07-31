namespace OOP3_Restaurant;

public class MenuItem
{
    public string itemName;
    public double price;
    public string courseCategory;
    public bool isSpecial;

    public MenuItem(string name , double pr , string category , bool special = false)
    {
        itemName = name;
        price = pr;
        courseCategory = category;
        isSpecial = special;
    }

    public double GetFinalPrice()
    {
        if(isSpecial)
            return price - (price * 0.30);
        return price;
    }
}
