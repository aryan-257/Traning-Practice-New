namespace Q4_PayrollEngine;

public abstract class Employee
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    private double _baseSalary;
    public double BaseSalary
    {
        get { return _baseSalary; }
        set
        {
            if(value < 0)
                throw new Exception("Salary cannot be negative");
            _baseSalary = value;
        }
    }

    public abstract double CalculateSalary();
    public abstract double CalculateBonus();
}
