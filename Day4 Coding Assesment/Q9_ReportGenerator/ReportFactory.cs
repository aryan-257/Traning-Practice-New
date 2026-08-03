namespace Q9_ReportGenerator;

public static class ReportFactory
{
    public static BaseReport Create(string type)
    {
        if(type == "PDF")   return new PdfReport();
        if(type == "Excel") return new ExcelReport();
        if(type == "CSV")   return new CsvReport();
        throw new Exception("Unknown report type : " + type);
    }
}
