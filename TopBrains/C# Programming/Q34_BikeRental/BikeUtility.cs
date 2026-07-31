namespace Q34_BikeRental;

public class BikeUtility
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = bikeDetails.Count + 1;
        bikeDetails.Add(key, new Bike { Model = model, Brand = brand, PricePerDay = pricePerDay });
        Console.WriteLine("Bike details added successfully");
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        var grouped = new SortedDictionary<string, List<Bike>>();

        foreach (var entry in bikeDetails)
        {
            string brand = entry.Value.Brand;
            if (!grouped.ContainsKey(brand))
                grouped[brand] = new List<Bike>();
            grouped[brand].Add(entry.Value);
        }

        return grouped;
    }
}
