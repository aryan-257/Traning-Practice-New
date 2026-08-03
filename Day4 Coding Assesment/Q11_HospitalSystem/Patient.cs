namespace Q11_HospitalSystem;

public class Patient : Person , IPrintable
{
    public string ailment;
    public double billAmount;

    public Patient(string id , string name , int age , string ail , double bill)
    {
        Id = id; Name = name; Age = age; ailment = ail; billAmount = bill;
    }

    public void Print()
    {
        Console.WriteLine($"Patient [{Id}] {Name} | Age:{Age} | {ailment} | Bill:Rs.{billAmount}");
    }
}
