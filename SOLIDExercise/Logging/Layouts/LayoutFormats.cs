using System.Globalization;

namespace Logging.Layouts;

public static class LayoutFormats
{
    public const string DefaultDateFormat = "M/d/yyyy h:mm:ss tt";

    public static string FormatDate(DateTime time, string dateFormat)
        => time.ToString(dateFormat, CultureInfo.InvariantCulture);

    public static string FormatLevel(Enum level) => level.ToString().ToUpperInvariant();
}
