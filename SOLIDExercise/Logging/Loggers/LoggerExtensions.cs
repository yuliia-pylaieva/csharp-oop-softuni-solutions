using Logging.Enums;
using Logging.Interfaces;

namespace Logging.Loggers;

public static class LoggerExtensions
{
    public static void Info(this ILogger logger, string message, DateTime time) => logger.Log(ReportLevel.Info, message, time);
    public static void Warning(this ILogger logger, string message, DateTime time) => logger.Log(ReportLevel.Warning, message, time);
    public static void Error(this ILogger logger, string message, DateTime time) => logger.Log(ReportLevel.Error, message, time);
    public static void Critical(this ILogger logger, string message, DateTime time) => logger.Log(ReportLevel.Critical, message, time);
    public static void Fatal(this ILogger logger, string message, DateTime time) => logger.Log(ReportLevel.Fatal, message, time);
}
