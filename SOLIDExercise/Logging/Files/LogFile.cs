using Logging.Interfaces;

namespace Logging.Files;

public class LogFile : ILogFile
{
    private readonly string _path;

    public LogFile(string path)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);
        _path = path;
    }

    public int Size { get; private set; }

    public void Write(string formattedLogMessage)
    {
        File.AppendAllLines(_path, [formattedLogMessage]);

        foreach (char c in formattedLogMessage)
        {
            if (char.IsAsciiLetter(c))
                Size += c;
        }
    }
}
