namespace OOP3_Restaurant;

public class Restaurant
{
    public string name;
    public string location;
    public List<MenuItem> menuItems = new List<MenuItem>();

    public Restaurant(string n , string loc)
    {
        name = n;
        location = loc;
    }

    public void AddItem(MenuItem item)
    {
        menuItems.Add(item);
    }

    public int TotalMenuItems()
    {
        return menuItems.Count;
    }

    public List<MenuItem> GetByCategory(string cat)
    {
        List<MenuItem> res = new List<MenuItem>();
        foreach(var item in menuItems)
        {
            if(item.courseCategory.ToLower() == cat.ToLower())
                res.Add(item);
        }
        return res;
    }

    public List<MenuItem> GetSpecialMenus()
    {
        List<MenuItem> res = new List<MenuItem>();
        foreach(var item in menuItems)
        {
            if(item.isSpecial)
                res.Add(item);
        }
        return res;
    }
}
