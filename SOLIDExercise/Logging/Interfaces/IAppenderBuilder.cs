namespace Logging.Interfaces;

public interface IAppenderBuilder
{
    // data: [appender type, layout type, optional report level]
    IAppender Build(string[] data);
}
