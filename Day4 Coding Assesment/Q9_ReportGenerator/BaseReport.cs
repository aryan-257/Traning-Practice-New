namespace Q9_ReportGenerator;

public abstract class BaseReport : IExportable
{
    public string reportName;
    public List<object> rows = new List<object>();

    public BaseReport(string name)
    {
        reportName = name;
    }

    public void AddRow(object row)
    {
        rows.Add(row);
    }

    public abstract void Generate();
    public abstract void Export();
}
