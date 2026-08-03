namespace Q4_PayrollEngine;

public class PermanentEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary;
    }

    public override double CalculateBonus()
    {
        return BaseSalary * 0.20;
    }
}
