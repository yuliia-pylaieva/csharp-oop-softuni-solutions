using Logging.Enums;

namespace Logging.Interfaces;

public interface ILogger
{
    IReadOnlyCollection<IAppender> Appenders { get; }

    void Log(ReportLevel reportLevel, string message, DateTime time);
}
