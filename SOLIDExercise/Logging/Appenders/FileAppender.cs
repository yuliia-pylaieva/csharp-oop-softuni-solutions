using Logging.Enums;
using Logging.Interfaces;

namespace Logging.Appenders;

public class FileAppender : Appender
{
    private readonly ILogFile _file;

    public FileAppender(ILogFile file, ILayout layout, Func<ILogMessage, bool>? filter = null) : base(layout, filter)
    {
        ArgumentNullException.ThrowIfNull(file);
        _file = file;
    }

    protected override void Append(string formattedLogMessage)
    {
        _file.Write(formattedLogMessage);
    }

    public override string ToString() => $"{base.ToString()}, File size: {_file.Size}";
}
