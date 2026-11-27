using Logging.Appenders;
using Logging.Files;
using Logging.Interfaces;
using Logging.Interfaces.Factories;

namespace Logging.Factories.Appenders;

public class FileAppenderFactory : IAppenderFactory
{
    private readonly string _filePath;

    public FileAppenderFactory(string filePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);
        _filePath = filePath;
    }

    public IAppender CreateAppender(ILayout layout, Func<ILogMessage, bool>? filter = null)
        => new FileAppender(new LogFile(_filePath), layout, filter);
}
