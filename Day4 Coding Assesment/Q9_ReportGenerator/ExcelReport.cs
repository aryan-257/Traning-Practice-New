namespace Q9_ReportGenerator;

public class ExcelReport : BaseReport
{
    public ExcelReport() : base("Excel Report") {}

    public override void Generate()
    {
        Console.WriteLine($"\n=== Generating {reportName} ===");
        foreach(var row in rows)
            Console.WriteLine("  " + row.ToString());
    }

    public override void Export()
    {
        Console.WriteLine($"Exporting {reportName} as .xlsx file");
    }
}
