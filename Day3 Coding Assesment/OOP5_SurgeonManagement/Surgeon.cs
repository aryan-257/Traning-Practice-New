namespace OOP5_SurgeonManagement;

public abstract class Surgeon
{
    public string name;
    public int surgeonId;

    public Surgeon(string n , int id)
    {
        name = n;
        surgeonId = id;
    }

    public abstract string GetSurgeonType();
}

public class SeniorSurgeon : Surgeon
{
    public SeniorSurgeon(string n , int id) : base(n,id) {}
    public override string GetSurgeonType() => "Senior";
}

public class NonSeniorSurgeon : Surgeon
{
    public NonSeniorSurgeon(string n , int id) : base(n,id) {}
    public override string GetSurgeonType() => "Non-Senior";
}
