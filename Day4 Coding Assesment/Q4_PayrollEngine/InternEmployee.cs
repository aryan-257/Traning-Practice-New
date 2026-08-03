namespace Q4_PayrollEngine;

public class InternEmployee : Employee
{
    public override double CalculateSalary()
    {
        return BaseSalary * 0.5;
    }

    public override double CalculateBonus()
    {
        return 0;
    }
}
