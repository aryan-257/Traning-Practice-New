namespace Q4_PayrollEngine;

public class ContractEmployee : Employee
{
    public int hoursWorked;
    public double hourlyRate;

    public ContractEmployee(int hours , double rate)
    {
        hoursWorked = hours;
        hourlyRate = rate;
    }

    public override double CalculateSalary()
    {
        return hoursWorked * hourlyRate;
    }

    public override double CalculateBonus()
    {
        return CalculateSalary() * 0.05;
    }
}
