using System.Collections.Generic;
/// <summary>
/// Строка отчета
/// </summary>
public class ReportRow
{
    public Dictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
}