namespace Q9_ReportGenerator;

public class CsvReport : BaseReport
{
    public CsvReport() : base("CSV Report") {}

    public override void Generate()
    {
        Console.WriteLine($"\n=== Generating {reportName} ===");
        foreach(var row in rows)
            Console.WriteLine("  " + row.ToString());
    }

    public override void Export()
    {
        Console.WriteLine($"Exporting {reportName} as .csv file");
    }
}
