namespace Logging.Enums;

// The order of the members matters: appender filters compare levels by their numeric value
// (Info < Warning < Error < Critical < Fatal). Do not reorder; add new levels in the right position.
public enum ReportLevel
{
    Info,
    Warning,
    Error,
    Critical,
    Fatal
}
