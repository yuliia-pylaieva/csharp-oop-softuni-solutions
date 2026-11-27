using Logging.Enums;
using Logging.Interfaces;
using Logging.Models;

namespace Logging.Loggers;

public class Logger : ILogger
{
    private readonly IAppender[] _appenders;

    public Logger(params IAppender[] appenders)
    {
        ArgumentNullException.ThrowIfNull(appenders);
        this._appenders = appenders;
    }

    public IReadOnlyCollection<IAppender> Appenders => this._appenders;

    public void Log(ReportLevel reportLevel, string message, DateTime time)
    {
        ILogMessage logMessage = new LogMessage(reportLevel, message, time);
        foreach (IAppender appender in _appenders)
            appender.Append(logMessage);
    }
}
