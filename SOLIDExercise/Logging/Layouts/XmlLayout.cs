using System.Text;
using Logging.Interfaces;

namespace Logging.Layouts;

public class XmlLayout : ILayout
{
    private readonly string _dateFormat;

    public XmlLayout(string dateFormat = LayoutFormats.DefaultDateFormat)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(dateFormat);
        _dateFormat = dateFormat;
    }

    public string Format(ILogMessage logMessage)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("<log>");
        stringBuilder.AppendLine($"   <date>{LayoutFormats.FormatDate(logMessage.Time, _dateFormat)}</date>");
        stringBuilder.AppendLine($"   <level>{LayoutFormats.FormatLevel(logMessage.ReportLevel)}</level>");
        stringBuilder.AppendLine($"   <message>{logMessage.Message}</message>");
        stringBuilder.Append("</log>");

        return stringBuilder.ToString();
    }
}
