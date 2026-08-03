namespace Q9_ReportGenerator;

public static class ReportExtensions
{
    public static string FormatAsTitle(this string text)
    {
        return "[ " + text.ToUpper() + " ]";
    }
}
