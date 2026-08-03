using Q4_PayrollEngine;

var employees = new List<Employee>
{
    new PermanentEmployee { Id=1 , Name="Pankaj" , BaseSalary=50000 },
    new PermanentEmployee { Id=2 , Name="Sneha"  , BaseSalary=60000 },
    new ContractEmployee(160 , 500) { Id=3 , Name="Rahul" },
    new InternEmployee   { Id=4 , Name="Aryan"  , BaseSalary=15000 }
};

Console.WriteLine("=== Payroll Report ===\n");

foreach(var emp in employees)
{
    var report = new
    {
        emp.Id,
        emp.Name,
        Type    = emp.GetType().Name,
        Salary  = emp.CalculateSalary(),
        Bonus   = emp.CalculateBonus(),
        Total   = emp.CalculateSalary() + emp.CalculateBonus()
    };

    Console.WriteLine($"ID:{report.Id} | {report.Name} | {report.Type}");
    Console.WriteLine($"  Salary={report.Salary} | Bonus={report.Bonus} | Total={report.Total}");
    Console.WriteLine();
}
