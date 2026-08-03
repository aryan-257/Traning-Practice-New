namespace Q9_ReportGenerator;

public class PdfReport : BaseReport
{
    public PdfReport() : base("PDF Report") {}

    public override void Generate()
    {
        Console.WriteLine($"\n=== Generating {reportName} ===");
        foreach(var row in rows)
            Console.WriteLine("  " + row.ToString());
    }

    public override void Export()
    {
        Console.WriteLine($"Exporting {reportName} as .pdf file");
    }
}
