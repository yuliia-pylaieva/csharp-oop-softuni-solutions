using Logging.Interfaces;

namespace Logging.Layouts;

public class SimpleLayout : ILayout
{
    private readonly string _dateFormat;

    public SimpleLayout(string dateFormat = LayoutFormats.DefaultDateFormat)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(dateFormat);
        _dateFormat = dateFormat;
    }

    public string Format(ILogMessage logMessage)
    {
        return $"{LayoutFormats.FormatDate(logMessage.Time, _dateFormat)} - {LayoutFormats.FormatLevel(logMessage.ReportLevel)} - {logMessage.Message}";
    }
}
