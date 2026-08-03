namespace Q11_HospitalSystem;

public class Doctor : Person , IPrintable
{
    public string specialization;

    public Doctor(string id , string name , int age , string spec)
    {
        Id = id; Name = name; Age = age; specialization = spec;
    }

    public void Print()
    {
        Console.WriteLine($"Doctor [{Id}] {Name} | Age:{Age} | {specialization}");
    }
}
