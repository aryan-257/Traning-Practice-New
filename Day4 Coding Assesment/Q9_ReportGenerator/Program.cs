using Q9_ReportGenerator;

foreach(var type in new[]{"PDF","Excel","CSV"})
{
    var report = ReportFactory.Create(type);

    report.AddRow(new { Name="Aryan"  , Score=95 , Grade="A" });
    report.AddRow(new { Name="Sneha"  , Score=88 , Grade="B" });
    report.AddRow(new { Name="Rahul"  , Score=72 , Grade="C" });

    report.Generate();
    report.Export();
    Console.WriteLine(report.reportName.FormatAsTitle());
}
